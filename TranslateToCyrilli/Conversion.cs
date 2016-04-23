using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateToCyrillic
{
    /************************************************************************************************
            |a|	    А а	|a|	
            |b|	    Б б	|b|	
            |v|	    В в	|v|	
            |g|,    Г г	|g|, gh	gh used before i or e, elsewhere g
            |d|     Д д	|d|
            |e|,    Е е	|e|, ie	ie after a vowel or else if it alternates with ia, elsewhere e
            |j|     Ж ж	|j|
            |g|,    Ӂ ӂ	|g|, ge, gi	g before i and e, ge before a, gi elsewhere
            |z|	    З з	|z|	
            |i|,    И и	|i|, ii[citation needed]	ii used at end of word, i elsewhere
            |i|	    Й й	|i|	before and after vowels
            |c|,    К к	|c|, ch	ch before i and e, c elsewhere
            |l|	    Л л	|l|	
            |m|	    М м	|m|	
            |n|	    Н н	|n|	
            |o|	    О о	|o|	
            |p|	    П п	|p|	
            |r|     Р р	|r|
            |s|	    С с	|s|	
            |t|	    Т т	|t|	
            |u|	    У у	|u|	
            |f|	    Ф ф	|f|	
            |h|	    Х х	|h|	
           Ț|ț|	    Ц ц	|ț|	
            |c|,    Ч ч	|c|, ce, ci	c before i and e, ce before a, ci elsewhere
            |ș|	    Ш ш	|ș|	
            |â|,    Ы ы	|â|, î	â in middle of word, î at beginning and end of word
            |i|	    Ь ь	|i|	At end of word (usually)
            |ă|	    Э э	|ă|	
            |iu|    Ю ю	|iu|	
            |ea|    Я я	|ea|, ia	ea after a consonant or е, ia elsewhere
    ********************************************************************************************************/
    class Conversion
    {
        public Conversion()
        {

        }

        public string Letters(ref char ch0, ref char ch, ref char ch2)
        {
            // initialize return value
            string letters = "";

            // If the chars were punctuation
            /*****************************************/
            if (ch == ' ')
            {
                letters = " ";
            }
            else if (ch == '-')
            {
                letters = "-";
            }
            else if (ch == ',')
            {
                letters = ",";
            }
            else if (ch == '.')
            {
                letters = ".";
            }
            else if (ch == '\'')
            {
                letters = "'";
            }
            else if (ch == '\n')
            {
                letters = "\n";
            }
            else if (ch == ';')
            {
                letters = ";";
            }
            else if (ch == ':')
            {
                letters = ":";
            }
            else if (ch == '"')
            {
                letters = "\"";
            }
            else if (ch == '?')
            {
                letters = "?";
            }
            else if (ch == '!')
            {
                letters = "!";
            }
            /******************************************/

            else if (ch == 'A' || ch == 'a')
            {
                letters = (char.IsUpper(ch) ? 'A' : 'a').ToString();

            }
            else if (ch == 'B' || ch == 'b')
            {
                letters = (char.IsUpper(ch) ? 'Б' : 'б').ToString();
            }
            else if (ch == 'V' || ch == 'v')
            {
                letters = (char.IsUpper(ch) ? 'В' : 'в').ToString();

            }
            else if (ch == 'G' || ch == 'g')
            {
                if (ch2 == 'I' || ch2 == 'i' || ch2 == 'E' || ch2 == 'e')
                {
                    letters = (char.IsUpper(ch) ? 'Ӂ' : 'ӂ').ToString();  // Ӂ ӂ    ge, gi g before iand e, ge before a, gi elsewhere
                }
                else
                {
                    letters = (char.IsUpper(ch) ? 'Г' : 'г').ToString();  //  Г г   |g|, gh	gh used before i or e, elsewhere g
                }

            }
            else if (ch == 'D' || ch == 'd')
            {
                letters = (char.IsUpper(ch) ? 'Д' : 'д').ToString();

            }
            else if (ch == 'E' || ch == 'e')
            {
                /*if e is followed by any vowel but a, and is the beginning of the word*/
                if ((ch0 == '0' || ch0 == ' ') && (ch2 == 'e' || ch2 == 'i' || ch2 == 'o' || ch2 == 'U' || ch2 == 'u' || ch2 == 'E' || ch2 == 'I'))
                {
                    //Й й | ie | at beginning of word
                    letters = (char.IsUpper(ch) ? 'Й' : 'й').ToString() + (char.IsUpper(ch2) ? 'Е' : 'е').ToString();
                }
                else if (ch2 == 'a' || ch2 == 'A')
                {
                    letters = (char.IsUpper(ch) ? 'Я' : 'я').ToString();
                }
                else
                {
                    letters = (char.IsUpper(ch) ? 'Е' : 'е').ToString();
                }

            }
            else if (ch == 'J' || ch == 'j')
            {
                letters = (char.IsUpper(ch) ? 'Ж' : 'ж').ToString();

            }
            else if (ch == 'Z' || ch == 'z')
            {
                if (ch2 == 'Z' || ch2 == 'z')
                {
                    letters = (char.IsUpper(ch) ? 'Ц' : 'ц').ToString();

                }
                else if (ch0 == 'Z' || ch0 == 'z')
                {
                    letters = "";
                }
                else
                {
                    letters = (char.IsUpper(ch) ? 'З' : 'з').ToString();

                }
            }
            else if (ch == 'C' || ch == 'c')
            {
                // If c is a ch sound with a vowel
                if (ch2 == 'I' || ch2 == 'E' || ch2 == 'i' || ch2 == 'e')
                {
                    letters = (char.IsUpper(ch) ? 'Ч' : 'ч').ToString();
                }
                else
                {
                    letters = (char.IsUpper(ch) ? 'К' : 'к').ToString();
                }

            }
            else if (ch == 'L' || ch == 'l')
            {
                letters = (char.IsUpper(ch) ? 'Л' : 'л').ToString();

            }
            else if (ch == 'M' || ch == 'm')
            {
                letters = (char.IsUpper(ch) ? 'М' : 'м').ToString();

            }
            else if (ch == 'N' || ch == 'n')
            {
                letters = (char.IsUpper(ch) ? 'Н' : 'н').ToString();

            }
            else if (ch == 'O' || ch == 'o')
            {
                letters = (char.IsUpper(ch) ? 'О' : 'о').ToString();

            }
            else if (ch == 'P' || ch == 'p')
            {
                letters = (char.IsUpper(ch) ? 'П' : 'п').ToString();

            }
            else if (ch == 'Q' || ch == 'q')
            {
                if (ch2 == 'U' || ch2 == 'u')
                {
                    letters = (char.IsUpper(ch) ? 'К' : 'к').ToString() /* + (char.IsUpper(ch2) ? 'У' : 'у').ToString()*/;
                }
            }
            else if (ch == 'R' || ch == 'r')
            {
                letters = (char.IsUpper(ch) ? 'Р' : 'р').ToString();

            }
            else if (ch == 'S' || ch == 's')
            {
                // If it's Sh
                if (ch2 == 'H' || ch2 == 'h')
                {
                    letters = (char.IsUpper(ch) ? 'Ш' : 'ш').ToString();

                }
                // If it makes ts sound, skip this letter
                else if (ch0 == 't')
                {
                    letters = "";
                }
                else
                {
                    letters = (char.IsUpper(ch) ? 'С' : 'с').ToString();
                }

            }
            else if (ch == 'T' || ch == 't')
            {
                // If it makes Ts
                if (ch2 == 'S' || ch2 == 's')
                {
                    letters = (char.IsUpper(ch) ? 'Ц' : 'ц').ToString();
                }
                else
                {
                    letters = (char.IsUpper(ch) ? 'Т' : 'т').ToString();
                }

            }
            else if ((ch0 != 'I' && ch0 != 'i') && (ch == 'U' || ch == 'u'))
            {
                // If it doesn't make iu
                letters = (char.IsUpper(ch) ? 'У' : 'у').ToString();
            }
            else if (ch == 'F' || ch == 'f')
            {
                letters = (char.IsUpper(ch) ? 'Ф' : 'ф').ToString();

            }
            else if (ch == 'H' || ch == 'h')
            {
                if (ch0 == 'S' || ch0 == 's')
                {
                    letters = "";
                }
                else if (ch0 == 'W' || ch0 == 'w')
                {
                    letters = "";
                }
                else if (ch0 == 'T' || ch0 == 't')
                {
                    letters = "";
                }
                else
                {
                    letters = (char.IsUpper(ch) ? 'Х' : 'х').ToString();
                }
            }
            else if (ch == 'I' || ch == 'i')
            {
                /* If letter after is i or it's in the middle of the word*/
                if (ch2 == 'I' || ch2 == 'i')
                {
                    //И и | i |, ii  ii used at end of word, i elsewhere
                    letters = (char.IsUpper(ch) ? 'И' : 'и').ToString();
                }
                /*If it's a silent i at end of word*/
                else if (ch2 == '2' && ch0 != 'I' && ch0 != 'i')
                {
                    //Ь ь | i | At end of word(usually)
                    letters = (char.IsUpper(ch) ? 'Ь' : 'ь').ToString();
                }
                /*if I is followed by any vowel but u*/
                else if (ch2 == 'a' || ch2 == 'e' || ch2 == 'i' || ch2 == 'o' || ch2 == 'A' || ch2 == 'E' || ch2 == 'I' || ch2 == 'O')
                {
                    //Й й | i | before and after vowels
                    letters = (char.IsUpper(ch) ? 'Й' : 'й').ToString();
                }
                /*if I is preceeded by any vowel*/
                else if (ch0 == 'a' || ch0 == 'e' || ch0 == 'i' || ch0 == 'o' || ch0 == 'u' || ch0 == 'A' || ch0 == 'E' || ch0 == 'I' || ch0 == 'O' || ch0 == 'U')
                {
                    //Й й | i | before and after vowels
                    letters = (char.IsUpper(ch) ? 'Й' : 'й').ToString();
                }
                /* if it's iu*/
                else if (ch2 == 'U' || ch2 == 'u')
                {
                    //| iu | Ю ю | iu |
                    letters = (char.IsUpper(ch) ? 'Ю' : 'ю').ToString();
                }
                else
                {
                    letters = (char.IsUpper(ch) ? 'И' : 'и').ToString();
                }

            }
            else if (ch == 'Y' || ch == 'y')
            {
                if (ch0 == 'M' || ch0 == 'm' || ch0 == 'R' || ch0 == 'r' || ch0 == 'K' || ch0 == 'k' || ch0 == 'L' || ch0 == 'l' || ch0 == 'U' || ch0 == 'u')
                {
                    letters = "a" + (char.IsUpper(ch) ? 'Й' : 'й').ToString();
                }
                else
                {
                    letters = (char.IsUpper(ch) ? 'Й' : 'й').ToString();
                }
            }
            else if (ch == 'W' || ch == 'w')
            {
                if (ch2 != '2')
                {
                    letters = (char.IsUpper(ch) ? 'У' : 'у').ToString();
                }
            }
            else if (ch == 'Ț' || ch == 'ț')
            {
                letters = (char.IsUpper(ch) ? 'Ц' : 'ц').ToString();
            }
            else if (ch == 'Ș' || ch == 'ș')
            {
                letters = (char.IsUpper(ch) ? 'Ш' : 'ш').ToString();
            }
            else if (ch == 'Â' || ch == 'â' || ch == 'Î' || ch == 'î')
            {
                letters = (char.IsUpper(ch) ? 'Ы' : 'ы').ToString();
            }
            else if (ch == 'Ă' || ch == 'ă')
            {
                letters = (char.IsUpper(ch) ? 'Э' : 'э').ToString();
            }
            return letters;
        }
    }
}