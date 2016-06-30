using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ModifyCode
{
    public class FileToolManager
    {
        private static FileToolManager _instance;
        public static FileToolManager Instance
        {
            get {
                if (null == _instance) _instance = new FileToolManager();
                return _instance;
            }
        }

        private List<string> handleFiles = new List<string>();
        public static int FindFiles(string path,string filter,bool clearAuto = false)
        {
            try
            {
                //    Instance.handleFiles 
                var result = Directory.GetFiles(path, filter, SearchOption.AllDirectories);
                if (clearAuto)
                {
                    Instance.handleFiles = result?.ToList<string>();
                }
                else
                {
                    Instance.handleFiles.AddRange(result);
                }
        
                return (int)(Instance.handleFiles?.Count);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return 0;
            }

        }
        public static bool AddToFirstLine(string content)
        {
            if (!string.IsNullOrWhiteSpace(content) && Instance.handleFiles.Count > 0)
            {
                try
                {
                    foreach (string filePath in Instance.handleFiles)
                    {
                        var fileContent = File.ReadLines(filePath);
                       List<string> contentFile = fileContent.ToList<string>();
                        contentFile.Insert(0, content);
                        File.WriteAllLines(filePath, contentFile);
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }

                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool AddToLastLine(string content)
        {
            if (!string.IsNullOrWhiteSpace(content) && Instance.handleFiles.Count > 0)
            {
                try
                {
                    foreach (string filePath in Instance.handleFiles)
                    {
                        var fileContent = File.ReadLines(filePath);
                        List<string> contentFile = fileContent.ToList<string>();
                        contentFile.Add(content);
                        File.WriteAllLines(filePath, contentFile);
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }

                return true;
            }
            else
            {
                return false;
            }
        }
        public static void ClearFiles()
        {
            Instance.handleFiles.Clear();
        }
        public static int GetLineCountOfFile(string file)
        {
            int result = 0;
            try
            {
                var fileContent = File.ReadLines(file);
         //       List<string> contentFile = fileContent.ToList<string>();
                result = fileContent.Count();
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                result = 0;
            }
            return result;
        }
        public static int GetLineCountOfAllFiles()
        {
            int result = 0;
            if(Instance.handleFiles?.Count >0)
            {
                foreach (string file in Instance.handleFiles)
                {
                    result += GetLineCountOfFile(file);
                }
            }
 
            return result;
        }
    }
}
