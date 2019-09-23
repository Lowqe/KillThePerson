using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ContentDisplay : MonoBehaviour
{
    [SerializeField] private Content content;
    [SerializeField] private Text name;
    [SerializeField] private Text description;
    [SerializeField] private Image Image;
    private string[] beskrivningar;
    private int pictureNumber;
    void Start()
    {
        pictureNumber = 0;
        //name.text = content.name;
        AddContent(content.Name);
        SetContent();
    }
    public void nextButton()
    {
        if(pictureNumber < (content.Image.Length-1))
        {
            pictureNumber++;
        }
        if (pictureNumber <= (content.Image.Length-1))
        {
            SetContent();
        }
    }
    public void previousButton()
    {
        
        if (pictureNumber > 0)
        {
            pictureNumber--;
        }
        if(pictureNumber >= 0)
        {
            SetContent();
        }
    }

    private void SetContent()
    {
        Image.sprite = content.Image[pictureNumber];
        description.text = beskrivningar[pictureNumber];
    }

    private void AddContent(string name)
    {
        switch (name)
        {
            case "Rosa Parks":
                beskrivningar = new string[3];
                beskrivningar[0] = "År 1955 kliver en kvinna vid namnet Rosa Parks på en buss på väg hem från jobbet.";
                beskrivningar[1] = "Hon sätter sig ner i delen av bussen som är avsedd för “färgade”.";
                beskrivningar[2] = "På bussens resa fylls de säten som är avsedda för “endast vita” " +
                    "och då busschauffören noterar att ett flertal vita människor står upp går han bak i bussen" +
                    " och säger åt fyra afroamerikaner att flytta bak ytterligare för att ge rum åt de vita. Parks " +
                    "vägrar ge upp sin plats. Hon anser att inte borde vara tvungen till det. Busschauffören ringer polisen " +
                    "och Parks blir arresterad. Händelsen utlöste Bussbojkotten i Montgomery, " +
                    "som brukar ses som starten för den moderna amerikanska medborgarrättsrörelsen.";
                    break;
            case "Mulford Akten":
                beskrivningar = new string[3];
                beskrivningar[0] = "1967 - Black panthers fortsatte vara en icke fredlig organisation och " +
                    "var inblandade i flera skottlossningar där flera blev skjutna. Vissa blev skadade, andra dog." +
                    " På grund av dessa skjutningar skapades en lag 1967 i Kalifornien med hjälp av guvernör Ronald Reagan " +
                    "som hindrade bärandet av vapen offentligt.";
                break;
            case "Washington Marschen":
                beskrivningar = new string[3];
                beskrivningar[0] = "1963 - King anordnar The March on Washington, där över 200 000 människor samlades för att marschera " +
                    "mot Washington. Malcolm X kallade händelsen för “A farce on Washington” och Nation of Islam förbjöd sina medlemmar " +
                    "att delta. Malcolm var kritisk till hela rörelsen och kallade King och de andra för springpojkar för det vita etablissemanget.";
                beskrivningar[1] = "De krävde ett slut på segregation mellan hudfärgerna i skolor, civila rättigheter lagstiftning som skulle skydda " +
                    "civila rättighetskämpare mot polis brutalitet och även en minimilön på två dollar i timmen för samtliga i Washington, DC.";
                beskrivningar[2] = "Kings berömda tal “I have a dream” levereras.";
                break;
            case "Malcolm X":
                beskrivningar = new string[3];
                beskrivningar[0] = "1957 - Malcolm X, högt uppsatt i organisationen Nation of Islam," +
                    " tillsammans med ett antal hundra andra personer står utanför en polisstation " +
                    "där bland andra Hinton Johnson hålls efter att ha blivit misshandlad och arresterad av amerikansk polis.";
                beskrivningar[1] = "Malcolm ordnar sjukvård åt Johnson efter att ha talat med polisen. När Johnson tas tillbaka " +
                    "till polisstationen har folkmassan vuxit till fyra tusen människor.";
                beskrivningar[2] = "Efter att polisen klargjort att Johnson inte kommer kunna släppas förrän dagen efter går Malcolm ut " +
                    "till folkmassan och sträcker upp en hand. Samtliga medlemmar i organisationen lämnade tyst och resten av massan " +
                    "följde led. En polis sa i en intervju med en tidning de kända orden “No one man should have that much power.”";
                break;
            case "Malcolms död":
                beskrivningar = new string[3];
                beskrivningar[0] = "1965 - Malcolm X lämnar Nation of Islam 1964 på grund av att han anser att organisationen har gått" +
                    " så långt den kan med de metoder de använder. Malcolm får dödshot till sig och sin familj ständigt under hela året.";
                beskrivningar[1] = "21:a februari 1965 förbereder Malcolm X att hålla ett tal inför en folkmassa på cirka 400 personer då " +
                    "ett bråk utbryter i publiken. Malcolms livvakter försöker bryta upp bråket. Då kliver en man fram till Malcolm med ett" +
                    " avsågat hagelgevär som han skjuter malcolm i magen med. Ytterligare två män använder handpistoler för att skjuta Malcolm. " +
                    "Totalt träffas han av 22 skott. Samtliga tre män arresterades och dömndes till livstid i fängelse.";
                beskrivningar[2] = "Anledning till mordet tros vara för att medlemmar i Nation of Islam ansåg att Malcolm satte sig emot deras " +
                    "ledare Elijah Muhammad för mycket.";
                break;
            case "Civilrättsakten":
                beskrivningar = new string[1];
                beskrivningar[0] = "1963 - 1964 - I juni 1963 lade John F.Kennedy fram förslaget om civila rättigheter";
                beskrivningar[1] = "Efter John F. Kennedy’s död 1964 fick kongressen igenom the civil rights act som illegaliserade" +
                    " diskriminering på grund av hudfärg, ras, religion, kön och ursprung. Angående civila rättigheter sa John F. Kennedy " +
                    "att “USA kommer inte vara fritt förrän alla sina medborgare är fria.”";
                break;
            case "OS Salut":
                beskrivningar = new string[3];
                beskrivningar[0] = "Tommie Smith har precis tagit hem OS-guld i löpning på 200 meter. " +
                    "Hans landsman John Carlos tog hem bronset. De två hade innan diskuterat att ha på sig " +
                    "svarta handskar om de båda hamnade på prispallen och utföra saluten men Carlos glömde sina.";
                beskrivningar[1] = "Det var silvermedaljören Peter Norman som kom med förslaget att de kunde dela " +
                    "på det paret de hade. Därför har Carlos sin handske på vänster trots att saluten traditionellt " +
                    "sett utförs med den högra.";
                beskrivningar[2] = "Under medaljceremonin höjde de en hand var som var klädda i svarta handskar under " +
                    "uppställandet av den amerikanska nationalsången. I Tommie Smiths självbiografi säger han att det inte " +
                    "var en höjd hand för “Black power” utan för mänskliga rättigheter. Detta anses vara det öppna politiska " +
                    "ställningstagandet i det moderna OS.";
                break;
            case "Black Panther":
                beskrivningar = new string[3];
                beskrivningar[0] = "1966 - Black panthers skapades efter att Malcolm X blev mördad av nation av islam och efter att en annan" +
                    " obeväpnad svart tonåring blev mördad av ett par poliser i San Francisco.";
                beskrivningar[1] = "Black panthers huvudsyfte var självförsvar, deras tidigare huvudaktiviteter var att bevaka polisen" +
                    " i “svarta” områden i Oklahoma och andra städer.";
                beskrivningar[2] = "De engagerade sig i politiska frågor, startade sociala program, bland andra Free Breakfast for Children, utbildning kring sjukdomar som tuberkulos, aids m.m. " +
                    "De blev väldigt populära och vid 1968 hade de ungefär 2000 medlemmar.";
                break;
            default:
                Debug.Log("inget namn");
                break;
        }
    }

}
