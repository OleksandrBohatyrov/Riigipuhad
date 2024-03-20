using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Riigipuhad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Riigipuhad : TabbedPage
    {
        public Riigipuhad()
        {
            InitializeComponent();

            Dictionary<string, CountryDetails[]> partCountries = new Dictionary<string, CountryDetails[]>
            {
               { "Euroopa", new CountryDetails[]
                    {
                        new CountryDetails { Name = "Ukraina", Description = "Ukraina on Ida-Euroopa riik, mille pealinn on Kiiev. Riik piirneb põhjas Valgevenega, läänes Poolaga, lõunas Ungariga, Slovakkia ja Rumeeniaga ning idas Venemaaga. Ukraina pindala on umbes 603 628 ruutkilomeetrit, mis teeb sellest Euroopa suuruselt teise riigi. Ukraina on rikas loodusvarade poolest ja tema majandus on üks Euroopa suurimaid. Riigi ametlik keel on ukraina keel ning suur osa rahvastikust on õigeusklikud kristlased.", ImageSource = "ukraine.png", Link = "https://et.wikipedia.org/wiki/Ukraina" },
                        new CountryDetails { Name = "Eesti", Description = "Eesti on Läänemere ääres asuv riik Põhja-Euroopas. Eestis on ilus loodus, kus on palju metsi, järvi ja saari. Pealinn on Tallinn, kus asub Eesti vanalinn ja Toompea loss. Eesti on väike riik, kuid selles on palju kultuuri ja ajalugu. Eesti keel on eesti keel ning suur osa rahvastikust kuulub luteri kirikusse.", ImageSource = "estonia.jpg", Link = "https://et.wikipedia.org/wiki/Eesti" },
                        new CountryDetails { Name = "Poola", Description = "Poola on Kesk-Euroopas asuv riik, mille pealinn on Varssavi. Poola piirneb põhjas Läänemerega, läänes Saksamaaga, lõunas Tšehhi ja Slovakkiaga ning idas Leedu, Valgevene ja Ukrainaga. Poola on suur riik, kus on palju ilusat loodust ja ajaloolisi vaatamisväärsusi. Poola keel on poola keel ning riigi suurim kirik on katoliku kirik.", ImageSource = "poland.jpg", Link = "https://et.wikipedia.org/wiki/Poola" }
                    }
                },
                { "Aasia", new CountryDetails[]
                    {
                        new CountryDetails { Name = "Hiina", Description = "Hiina on suur Aasia riik, mille pealinn on Peking.  Hiina on maailma kõige rahvarohkem riik, kus elab üle miljardi inimese. Hiina on ajalooline tsivilisatsioon, millel on rikas kultuur ja traditsioonid. Hiina keel on hiina keel ning suur osa rahvastikust kuulub budismi või konfutsianismi.", ImageSource = "china.jpg", Link = "https://et.wikipedia.org/wiki/Hiina" },
                        new CountryDetails { Name = "India", Description = "India on Lõuna-Aasias asuv suur riik, mille pealinn on New Delhi. India on mitmekesine riik, kus on erinevad keeled, kultuurid ja usundid. India on tuntud oma ajalooliste ehitiste, ilusa looduse ja värvikate festivalide poolest. India keel on hindi keel ning riigi suurim religioon on hinduism.", ImageSource = "india.jpg", Link = "https://et.wikipedia.org/wiki/India" },
                        new CountryDetails { Name = "Jaapan", Description = "Jaapan on Aasia riik, mis koosneb mitmest saarest. Jaapani pealinn on Tokyo. Jaapan on tehnoloogiliselt arenenud riik, kus on kaunis loodus ja põnev kultuur. Jaapani keel on jaapani keel ning riigi traditsiooniline religioon on šintoism.", ImageSource = "japan.jpg", Link = "https://et.wikipedia.org/wiki/Jaapan" }
                    }
                },
                   { "Lõuna-Ameerika", new CountryDetails[]
                    {
                        new CountryDetails { Name = "Brasiilia", Description = "Brasiilia on Lõuna-Ameerika suurim riik, mille pealinn on Brasiiliaia. Brasiilia on tuntud oma rikkaliku looduse, kauni rannajoone ja säravate karnevalide poolest. Brasiilia keel on portugali keel ning suur osa rahvastikust on katoliiklased.", ImageSource = "brazil.jpg", Link = "https://et.wikipedia.org/wiki/Brasiilia" },
                        new CountryDetails { Name = "Argentina", Description = "Argentina on Lõuna-Ameerika riik, mille pealinn on Buenos Aires. Argentina on tuntud oma tangomuusika, meeldiva kliima ja maitsva liha poolest. Riigi ametlik keel on hispaania keel ning suur osa rahvastikust on rooma-katoliiklased.", ImageSource = "argentina.jpg", Link = "https://et.wikipedia.org/wiki/Argentina" },
                        new CountryDetails { Name = "Kolumbia", Description = "Kolumbia on Lõuna-Ameerika riik, mille pealinn on Bogotá. Kolumbia on tuntud oma mitmekesise kultuuri, ilusa looduse ja kohaliku kohvi poolest. Riigi ametlik keel on hispaania keel ning suur osa rahvastikust kuulub rooma-katoliiklased.", ImageSource = "colombia.jpg" , Link = "https://et.wikipedia.org/wiki/Colombia"}
                    }
                },
                { "Okeaania", new CountryDetails[]
                    {
                        new CountryDetails { Name = "Austraalia", Description = "Austraalia on suur saareriik Okeaania lõunaosas, mille pealinn on Canberra. Austraalia on tuntud oma ainulaadse looduse, maailmatasemel linnade ja rikkaliku põlisrahvaste kultuuri poolest. Riigi ametlik keel on inglise keel ning suur osa rahvastikust on kristlased.", ImageSource = "australia.jpg" , Link = "https://et.wikipedia.org/wiki/Austraalia"},
                        new CountryDetails { Name = "Uus-Meremaa", Description = "Uus-Meremaa on Okeaania riik, mis koosneb kahest suurest saarest. Uus-Meremaa pealinn on Wellington. Riik on tuntud oma hämmastava looduse, mägironimise ja hobuste poolest. Riigi ametlik keel on inglise keel ning suur osa rahvastikust on anglikaani kristlased.", ImageSource = "new_zealand.jpg", Link = "https://et.wikipedia.org/wiki/Uus-Meremaa" },
                        new CountryDetails { Name = "Fidži", Description = "Fidži on Okeaania saareriik, mille pealinn on Suva. Fidži on tuntud oma kaunite randade, kõrgete mägede ja rikkaliku kultuuripärandi poolest. Riigi ametlik keel on fidži keel ning suur osa rahvastikust on kristlased.", ImageSource = "fiji.jpg", Link = "https://et.wikipedia.org/wiki/Fid%C5%BEi" }
                    }
                }
            };
            foreach (var part in partCountries)
            {
                var partPage = new TabbedPage
                {
                    Title = part.Key
                };

                foreach (var country in part.Value)
                {
                    var grid = new Grid();

      

                    var descriptionLabel = new Label
                    {
                        Text = country.Description,
                        FontSize = 20,
                        TextColor = Color.Black,
                        HorizontalTextAlignment = TextAlignment.Center,
              
                               Margin = new Thickness(0, 0, 0, 0)
                    };
                    grid.Children.Add(descriptionLabel);



                    var image = new Image
                    {
                        Source = country.ImageSource,
                        HeightRequest = 200,
                        Aspect = Aspect.AspectFit,
                        MinimumHeightRequest= 200,
                        
                    };
                    grid.Children.Add(image);

                    image.GestureRecognizers.Add(new TapGestureRecognizer
                    {
                        Command = new Command(() =>
                        {
                     
                            Device.OpenUri(new Uri(country.Link));
                        })
                    });


                    var countryPage = new ContentPage
                    {
                        Title = country.Name,
                        Content = grid 
                    };

                    partPage.Children.Add(countryPage);
                }

                Children.Add(partPage);
            }
        }
    }
}