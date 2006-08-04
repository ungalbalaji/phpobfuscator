using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Xml.Serialization;

namespace Obfuscation
{
    [Serializable]
    public class ObfuscationConfig
    {
        string _targetDir;
        string _sourceDir;
        bool _removeWhitespace;
        bool _renameVariables;
        bool _renameFunctions;
        string[] _excludeFunctions;
        string[] _excludeVariables;
        string[] _filesToObfuscate;

        public string[] FilesToObfuscate
        {
            get { return _filesToObfuscate; }
            set { _filesToObfuscate = value; }
        }

        public string[] ExcludeVariables
        {
            get { return _excludeVariables; }
            set { _excludeVariables = value; }
        }

        public string[] ExcludeFunctions
        {
            get { return _excludeFunctions; }
            set { _excludeFunctions = value; }
        }

        public bool RemoveWhitespace
        {
            get { return _removeWhitespace; }
            set { _removeWhitespace = value; }
        }

        public bool RenameVariables
        {
            get { return _renameVariables; }
            set { _renameVariables = value; }
        }
        
        public bool RenameFunctions
        {
            get { return _renameFunctions; }
            set { _renameFunctions = value; }
        }

        public string TargetDir
        {
            get { return _targetDir; }
            set { _targetDir = value; }
        }

        public string SourceDir
        {
            get { return _sourceDir; }
            set { _sourceDir = value; }
        }


        public void Save(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObfuscationConfig));
            FileStream file = File.Open(filename, FileMode.Create);

            serializer.Serialize(file, this);
            file.Close();
        }

        public static ObfuscationConfig Open(string filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ObfuscationConfig));
                FileStream file = File.Open(filename, FileMode.Open);

                return (ObfuscationConfig)serializer.Deserialize(file);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
