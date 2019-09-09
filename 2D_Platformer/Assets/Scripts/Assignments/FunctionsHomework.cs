using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
public class FunctionsHomework : MonoBehaviour 
{   // Function "CalcSub" Variables
    int subnum1;
    int subnum2;
    int subtotal;
    //Function "CalcMult" Variables
    int multnum1;
    int multnum2;
    int multtotal;
    //Function "Character" Variables
    string charfName;
    string charGender;
    int charAge;
    //Function "UtahLaw" Variables
    string lawStatement;
    int lawAge;
    string lawItem;
    //Function "PersonalLife" variables
    string meName;
    string meSchool;
    string meJob;
    int meAge;
 
 
    // Start is called before the first frame update 
    void Start() 
    { 
        //Function "CalcSub" Declaration
        subnum1 = 14;
        subnum2 = 32;
        //Function "CalcMult" Declaration
        multnum1 = 4;
        multnum2 = 5;
        //Function "Character" Declaration
        charfName = "Jenson";
        charGender = "Male";
        charAge = 32;
        //Function "UtahLaw" Declaration
        lawStatement = "You must be a certain age to smoke.";
        lawAge = 19;
        lawItem = "Cigarettes";
        //Function "PersonalLife" Declaration
        meName = "Connor";
        meSchool = "UVU";
        meJob = "Blaze Pizza";
        meAge = 19;
    
        //Calling CalcSub
        CalcSub(subnum1, subnum2);
        //Calling CalcMult
        CalcMult(multnum1, multnum2);
        //Calling Character
        Character(charfname, charGender, charAge);
        //Calling UtahLaw
        UtahLaw(lawStatement,lawAge,lawItem);
        //Calling PersonalLife
        PersonalLife(meName,meSchool,meJob,meAge); 
    } 
    //Function CalcSub
    int CalcSub(int x, int y) 
    { 
        total = x - y; 

        Debug.Log(total);

        return total;
    } 
    //Function CalcMult
    int CalcMult(int x, int y)
    {
        total = x * y;

        Debug.Log(total);

        return total;
    }
    //Function Character
    void Character(string name, string gender, int age)
    {
        Debug.Log(name + " " + "is" + " " + gender + " and is "+ age);
    }
    //Function UtahLaw
    void UtahLaw(string law, int age, string item)
    {
        Debug.Log(law + " " + "The age to smoke is " + age + " " + "This law is in regards to " + item);
    }
    //Function PersonalLife
    void PersonalLife(string name, string school, string job, string age)
    {
        Debug.Log("My name is " + name + " " + "I attend " + school + " " + "And I work at " + job + ".  " + "I am " + age + "years old.");
    }
} 