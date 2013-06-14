using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mime;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Management;

namespace SetAccessRights
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);

            foreach (string f in files)
            {
                SetAccessRights(f);
            }

            SetAccessRightsFolder(AppDomain.CurrentDomain.BaseDirectory);

        }



        private static void SetAccessRightsFolder(string sFolder)
        {

            DirectoryInfo myDirectoryInfo = new DirectoryInfo(sFolder);
            DirectorySecurity myDirectorySecurity = myDirectoryInfo.GetAccessControl();


            SelectQuery sQuery = new SelectQuery("Win32_UserAccount", "Domain='" + System.Environment.UserDomainName.ToString() + "'");


            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher(sQuery);

            foreach (ManagementObject mObject in mSearcher.Get())
            {
                string User = System.Environment.UserDomainName + "\\" + mObject["Name"];
                myDirectorySecurity.AddAccessRule(new FileSystemAccessRule(User, FileSystemRights.Read, AccessControlType.Allow));
                myDirectorySecurity.AddAccessRule(new FileSystemAccessRule(User, FileSystemRights.Write, AccessControlType.Allow));
                myDirectorySecurity.AddAccessRule(new FileSystemAccessRule(User, FileSystemRights.Modify, AccessControlType.Allow));
                myDirectorySecurity.AddAccessRule(new FileSystemAccessRule(User, FileSystemRights.FullControl, AccessControlType.Allow));
            }



            myDirectoryInfo.SetAccessControl(myDirectorySecurity);
        }


        private static void SetAccessRights(string file)
        {
            FileSecurity fileSecurity = File.GetAccessControl(file);
            AuthorizationRuleCollection rules = fileSecurity.GetAccessRules(true, true, typeof(NTAccount));

            foreach (FileSystemAccessRule rule in rules)
            {
                string name = rule.IdentityReference.Value;

                if (rule.FileSystemRights != FileSystemRights.FullControl)
                {
                    FileSecurity newFileSecurity = File.GetAccessControl(file);
                    FileSystemAccessRule newRule = new FileSystemAccessRule(name, FileSystemRights.FullControl, AccessControlType.Allow);
                    newFileSecurity.AddAccessRule(newRule);
                    File.SetAccessControl(file, newFileSecurity);
                }
            }
        }
    }
}
