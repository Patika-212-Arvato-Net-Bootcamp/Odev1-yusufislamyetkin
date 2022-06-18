using System;
using System.Collections.Generic;

namespace Arvato_Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool controlKey = true;
            Console.WriteLine("Yusuf İslam Bilişim'e Hoşgeldiniz");
            Console.WriteLine("");
            Console.WriteLine("Giriş yapmak için lütfen TC kimlik numaranızı girin.");

            // Liste oluşturma.
            List<String> TCnumber = new List<string>();
            List<String> Name = new List<string>();
            List<String> Surname = new List<string>();
            List<String> GSM = new List<string>();



            // Örnek Veri girişi.
            TCnumber.Add("27059340210");
            Name.Add("Yusuf İslam");
            Surname.Add("Yetkin");
            GSM.Add("5389351189");




            do
            {


                string TcValue = Console.ReadLine();
                double TcValueTryInt = 0;

                // TC nin düzgün girilip girilmediğinin kontrolü.
                if (TcValue.Length != 11)
                {
                    Console.WriteLine("");
                    Console.WriteLine("lütfen TC girişinizi kontrol edin. TC kimlik numaranız 11 karakter olmak zorundadır.");

                    Console.WriteLine("Giriş yapmak için lütfen TC kimlik numaranızı yeniden girin girin.");
                }
                else
                {

                    try
                    {
                        // Girilen veri sayısal mı kontrol sağlaması.
                        TcValueTryInt = double.Parse(TcValue);
                        //Sayısal veri ataması gerçekleşirse veriyi TcValue değişkenine atacak.
                        TcValue = TcValueTryInt.ToString();


                        if (TCnumber.Contains(TcValue))
                        {
                            //Eğer daha önceden böyle bir kullanıcı sistemde varsa indexini bulacak ve o kullanıcının verilerini getirecek.
                            int dgr = TCnumber.IndexOf(TcValue);
                            Console.WriteLine("Kullanıcı sistemde kayıtlı..");
                            Console.WriteLine("Ad : " + Name[dgr]);
                            Console.WriteLine("Soyad : " + Surname[dgr]);
                            Console.WriteLine("Gsm Numarası : " + GSM[dgr]);

                            Console.WriteLine("giriş yapılıyor...");
                            Console.WriteLine("giriş yapıldı...");
                        }


                        else
                        {
                            TCnumber.Add(TcValue);
                            Console.WriteLine("Kullanıcı sistemde bulunamadı..");
                            Console.WriteLine("***** Kayıt Ol *****");
                            Console.WriteLine("Kullanıcı ad giriniz");
                            string userName = Console.ReadLine();
                            Console.WriteLine("Kullanıcı soyad giriniz");
                            string userSurname = Console.ReadLine();
                            Console.WriteLine("Kullanıcı Gsm numarası giriniz");
                            string userGsm = Console.ReadLine();


                            Name.Add(userName);
                            Surname.Add(userSurname);
                            GSM.Add(userGsm);
                            Console.WriteLine("");
                            Console.WriteLine("Sisteme eklendiniz..");
                            Console.WriteLine("");

                        }


                        controlKey = false;
                    }
                    catch
                    {
                        Console.WriteLine("");
                        Console.WriteLine("lütfen TC girişinizi kontrol edin. TC kimlik numaranız sayısal ifadelerden oluşmak zorundadır.");

                        Console.WriteLine("Giriş yapmak için lütfen TC kimlik numaranızı yeniden girin girin.");

                    }

                }

            } while (controlKey);


            // Değişken tanımlamalarımızı en üste yazıyoruz her yerden erişebilmek için.
            int sumValue = 0;
           
            string myorder = "";



            bool siparischeck = false;
            do
            {
                Console.WriteLine("*****************");
                Console.WriteLine("Ürün Türü Seçiniz");
                Console.WriteLine("*****************");
                Console.WriteLine("");
                Console.WriteLine("1 - Laptop");
                Console.WriteLine("2 - Oyun Konsolu");
                Console.WriteLine("3 - Kulaklık");
                Console.WriteLine("");
                Console.Write(" Seçiminiz : ");
                string siparissecimi = Console.ReadLine();


                // Secim kontrolü sağlıyoruz, bu şekilde istediğimiz veri dışındaki verilerin gelmesini önlüyoruz.
                if (siparissecimi == "1" || siparissecimi == "2" || siparissecimi == "3")
                {


                    switch (siparissecimi)
                    {

                        case "1":
                            Console.WriteLine("");
                            Console.WriteLine("**************");
                            Console.WriteLine("Laptop Seçimi");
                            Console.WriteLine("**************");
                            Console.WriteLine("");
                            Console.WriteLine("1 - Monster Notebook A.1 7500 TL");
                            Console.WriteLine("2 - Monster Notebook A.2 8500 TL");
                            Console.WriteLine("3 - Monster Notebook A.3 9500 TL");
                          
                            Console.WriteLine("");
                            Console.Write(" Seçiminiz : ");
                            string urunsecimi = Console.ReadLine();


                            if (urunsecimi == "1" || urunsecimi == "2" || urunsecimi == "3" || urunsecimi == "4" || urunsecimi == "5")
                            {
                                switch (urunsecimi)
                                {
                                    case "1":
                                        sumValue = secimyap(7500);
                                        if (sumValue == 0)
                                        {

                                            siparischeck = true;
                                        }
                                        else
                                        {
                                            myorder = "Monster Notebook A.1 7500 TL";
                                          
                                            siparischeck = false;
                                        }


                                        break;
                                    case "2":

                                        sumValue = secimyap(8500);
                                        if (sumValue == 0)
                                        {
                                            siparischeck = true;
                                        }
                                        else
                                        {
                                            myorder = "Monster Notebook A.1 8500 TL";
                                          
                                            siparischeck = false;
                                        }


                                        break;

                                    case "3":
                                        sumValue = secimyap(9500);
                                        if (sumValue == 0)
                                        {
                                            siparischeck = true;
                                        }
                                        else
                                        {
                                            myorder = "Monster Notebook A.1 9500 TL";
                                           
                                            siparischeck = false;
                                        }


                                        break;
                                

                                }
                            }

                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Ürün seçilemedi lütfen belirlilen seçimlerden birini tuşlayın.");
                                siparischeck = true;
                                break;

                            }

                            break;


                        case "2":

                            Console.WriteLine("");
                            Console.WriteLine("**************");
                            Console.WriteLine("Oyun Konsolu Seçimi");
                            Console.WriteLine("**************");
                            Console.WriteLine("");
                            Console.WriteLine("1 - PS4 6500 TL");
                            Console.WriteLine("2 - PS5  8500 TL");
                            Console.WriteLine("3 - XBOX 9500 TL");

                            Console.WriteLine("");
                            Console.Write(" Seçiminiz : ");
                            urunsecimi = Console.ReadLine();


                            if (urunsecimi == "1" || urunsecimi == "2" || urunsecimi == "3")
                            {
                                switch (urunsecimi)
                                {
                                    case "1":
                                        sumValue = secimyap(650);
                                        if (sumValue == 0)
                                        {
                                            siparischeck = true;
                                        }
                                        else
                                        {
                                            myorder = "PS4 6500 TL";
                                           
                                            siparischeck = false;
                                        }


                                        break;
                                    case "2":

                                        sumValue = secimyap(8500);
                                        if (sumValue == 0)
                                        {
                                            siparischeck = true;
                                        }
                                        else
                                        {
                                            myorder = "PS5  8500 TL";
                                           
                                            siparischeck = false;
                                        }


                                        break;

                                    case "3":
                                        sumValue = secimyap(9500);
                                        if (sumValue == 0)
                                        {
                                            siparischeck = true;
                                        }
                                        else
                                        {
                                           
                                            myorder = "XBOX 9500 TL";
                                            siparischeck = false;
                                        }


                                        break;


                                }
                            }

                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Ürün seçilemedi lütfen belirlilen seçimlerden birini tuşlayın.");
                                siparischeck = true;
                                break;

                            }

                            break;



                        case "3":

                            Console.WriteLine("");
                            Console.WriteLine("**************");
                            Console.WriteLine("Kulaklık Seçimi");
                            Console.WriteLine("**************");
                            Console.WriteLine("");
                            Console.WriteLine("1 - Jbl Kablolu Kulaklık 170 TL");
                            Console.WriteLine("2 - Jbl Kablosuz Kulaklık  350 TL");
                            Console.WriteLine("3 - Apple Airpods 1600 TL");

                            Console.WriteLine("");
                            Console.Write(" Seçiminiz : ");
                            urunsecimi = Console.ReadLine();


                            if (urunsecimi == "1" || urunsecimi == "2" || urunsecimi == "3")
                            {
                                switch (urunsecimi)
                                {
                                    case "1":
                                        sumValue = secimyap(170);
                                        if (sumValue == 0)
                                        {
                                            siparischeck = true;
                                        }
                                        else
                                        {
                                            myorder = "Jbl Kablolu Kulaklık 170 TL";
                                          
                                            siparischeck = false;
                                        }


                                        break;
                                    case "2":

                                        sumValue = secimyap(350);
                                        if (sumValue == 0)
                                        {
                                            siparischeck = true;
                                        }
                                        else
                                        {
                                            myorder = "Jbl Kablosuz Kulaklık  350 TL";
                                           
                                            siparischeck = false;
                                        }


                                        break;

                                    case "3":
                                        sumValue = secimyap(1600);
                                        if (sumValue == 0)
                                        {
                                            siparischeck = true;
                                        }
                                        else
                                        {
                                           
                                            myorder = "Apple Airpods 1600 TL";
                                            siparischeck = false;
                                        }


                                        break;


                                }
                            }

                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Ürün seçilemedi lütfen belirlilen seçimlerden birini tuşlayın.");
                                siparischeck = true;
                                break;

                            }

                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Siparis seçilemedi lütfen belirlilen seçimlerden birini tuşlayın.");
                    siparischeck = true;

                }
            } while (siparischeck);

            Console.WriteLine("");
            Console.WriteLine("***************");
            Console.WriteLine("Sipariş Bilgisi");
            Console.WriteLine("***************");
            Console.WriteLine("");

            // Listeye en son eklenen veri için listenin ters çevrimi.
            TCnumber.Reverse();
            Name.Reverse();
            Surname.Reverse();
            GSM.Reverse();


       

            Console.WriteLine("Satın alınan ürün bilgisi : " + myorder);
         
            Console.WriteLine("Toplam tutar = " + sumValue + " TL" );
            Console.WriteLine("");
            Console.WriteLine("***********************");
            Console.WriteLine("Sipariş veren bilgileri ");
            Console.WriteLine("***********************");
            Console.WriteLine("");
            // En son eklenen veri en yukarıda olacağı için 0 ile veriyi çekiyoruz.
            Console.WriteLine("Kimlik bilgisi : " + TCnumber[0]);
            Console.WriteLine("Ad bilgisi : " + Name[0]);
            Console.WriteLine("Soyad bilgisi : " + Surname[0]);
            Console.WriteLine("Gsm bilgisi : " + GSM[0]);
            Console.WriteLine("");
            Console.WriteLine("Sipariş talebiniz alınmıştır en yakın sürede kargolanacaktır.");
            Console.WriteLine("Yusuf İslam Bilişim iyi günler diler. :)");

            Console.ReadLine();



            // Fiyat hesaplama method'u. Kod tekrarından kaçınmak bu şekilde oluşturdum.
           
             int secimyap(int price)
            {
                Console.WriteLine("");

                Console.WriteLine("Kaç adet satın almak istediğinizi girin.");
                Console.WriteLine("Maximum 3 adet satın alabilirsiniz.");
                Console.WriteLine("");
                Console.WriteLine("1 - Bir adet için");
                Console.WriteLine("2 - İki adet için");
                Console.WriteLine("3 - Üç adet için");
         
                Console.WriteLine("");
                Console.Write(" Seçiminiz : ");
                string pieceselection = Console.ReadLine();
                int sumValue = 0;

                if (pieceselection == "1" || pieceselection == "2" || pieceselection == "3" )
                {
                    int adet = Convert.ToInt32(pieceselection);
                    sumValue = price * adet;
                }
                else
                {
                    sumValue = 0;
                }

                return sumValue;
            }




        }


      
    }
}
