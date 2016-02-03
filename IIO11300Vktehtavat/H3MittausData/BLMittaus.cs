using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Translator
{
    public class MittausData
    {
        public string DataMuoto {
            get
            {
                return kello + ";" + mittaus;
            }
        }

        private string kello;

        public string Kello
        {
            get { return kello; }
            set { kello = value; }

        }

        private string mittaus;

        public string Mittaus {
            
            get{ return mittaus; }
            set{ mittaus = value; }
            
            }

        public String data;

        public override string ToString()
        {
            return kello + " " + mittaus;
        }


        #region METHODS

        public static void SaveDataToFile(List<MittausData> dataa, string filu) {



            try
            {

                if (System.IO.File.Exists(filu))
                {
                    using (StreamWriter sw = File.CreateText(filu))
                    {
                        foreach (var item in dataa)
                        {
                            sw.WriteLine(item.DataMuoto);
                        }
                    }
                }

                else {

                    using (StreamWriter sw = File.AppendText(filu))
                    {
                        foreach (var item in dataa)
                        {
                            sw.WriteLine(item.DataMuoto);
                        }
                    }


                }
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
            }
        

           public static List<MittausData> ReadDataFromFile(string filu) {

            //luetaan tekstirivejä käyttäjän tiedostoista ja muutetaan ne mittausdataksi

            try
            {
                if (File.Exists(filu)) {

                    using (StreamReader sr = File.OpenText(filu))
                    {

                        MittausData md;
                        List<MittausData> luetut = new List<MittausData>();
                        string rivi = " ";
                        while((rivi = sr.ReadLine()) != null)
                        {
                            if ((rivi.Length > 3) && rivi.Contains(";"))
                            {
                                string[] split = rivi.Split(new char[] { ';' });

                                md = new MittausData();
                                md.Kello = split[0];
                                md.Mittaus = split[1];
                                luetut.Add(md);
                            }
                        }
                        return luetut;
                    }

                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch (Exception ex)
            {
                throw ex;
                
            }

        }

        }
        #endregion

    }

