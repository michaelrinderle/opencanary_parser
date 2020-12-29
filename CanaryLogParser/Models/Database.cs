using CanaryLogParser.Models.Credential;
using CanaryLogParser.Models.Information;
using CanaryLogParser.Models.Port;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Reflection.Emit;

namespace CanaryLogParser.Models
{
    public class Database
    {
        public List<InformationLog> Informations { get; set; } = new List<InformationLog>();
        public List<CredentialLog> Credentials { get; set; } = new List<CredentialLog>();
        public List<PortLog> Ports { get; set; } = new List<PortLog>();

        public Database(string filename)
        {
            SortLogfile(filename);
        }

        private void SortLogfile(string file)
        {
            var entries = File.ReadLines(file);
            foreach(var entry in entries)
                SortRecord(entry);
        }

        private void SortRecord(string log)
        {
            try
            {
                
            if(log.Contains("\"logtype\": 2001"))
            {
                var info = JsonConvert.DeserializeObject<InformationLog>(log);
                Informations.Add(info);
            }
            else if(log.Contains("\"logtype\": 6001"))
            {
                var cred = JsonConvert.DeserializeObject<CredentialLog>(log);
                Credentials.Add(cred);
            }
            else if(log.Contains("\"logtype\": 5001"))
            {
                var port = JsonConvert.DeserializeObject<PortLog>(log);
                Ports.Add(port);
            }  
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }  
        }
    
        public void printPorts()
        {
            List<PortLog> uniqueIps = new List<PortLog>();


            foreach(var port in Ports.OrderBy(x => x.src_host))
            {
                if (!uniqueIps.Contains(port))
                    uniqueIps.Add(port);
                
            }

            foreach(var port in uniqueIps)
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry(port.src_host);
                Console.WriteLine($" Port Hit {port.dst_port} : Source {port.src_host} : DNS {host.HostName}");
            }

        }


        public void printCreds()
        {
            List<CredentialLog> creds = new List<CredentialLog>();
            List<string> hosts = new List<string>();

            foreach(var cred in Credentials.OrderBy(x => x.src_port))
            {
                if (hosts.Contains(cred.src_host))
                {

                }
                Console.WriteLine($"P{cred.dst_port}    : S {cred.src_host}         : U {cred.logdata.USERNAME}     : P {cred.logdata.PASSWORD}");
            }




        }
    }
}
