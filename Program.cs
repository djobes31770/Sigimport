using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using CommandLine;
using CommandLine.Text;
using CommandLine.Parsing;
using Sparser;

public class SigImport
{
    public void Run(string filename)
    {
        String rule;
        using (StreamReader sr = new StreamReader(filename))
        {
            StringWriter strwriter = new StringWriter();
            // call the proc_rgx() routine from the sparser library reference to format rules
            Console.WriteLine("Processing File ..........................." + filename);
            //Sparser.ParserMain.proc_rgx(filename);
            Sparser.ParserMain.test_db();
            while ((rule = sr.ReadLine()) != null)
            {                
            } // close the rule file and exit app
            sr.Close();
            return;
        }
    }

    public static void Main(string[] args)
    {
        SigImport si = new SigImport();
        si.Run(args[0]);
    }
}
