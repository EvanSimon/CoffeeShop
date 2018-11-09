

function testInputs()
{
    var FNRegEx = /^[a-zA-Z]{2,}$/g;
    var LNRegEx = /^[a-zA-Z]{2,}$/g;
    var EMRegEx = /"^[A-z0-9]{5,30}@[a-z]{5,10}.[a-z]{2,3}$"/g;
    var PWRegEx = /"^[a-zA-Z]{2,}$")/g;
    var element1 = document.getElementById("FirstName").value;
    var element2 = document.getElementById("LastName").value;   
    var element3 = document.getElementById("Email").value;
    var element4 = document.getElementById("PhoneNumber").vale;

    if (!element1.match(FNRegEx) || !element2.match(LNRegEx) || !element3.math(EMRegEx) || !element4.match(PWRegEx))
    {

        return false;
    }

    else
    {
        alert("You did not meet the requierd field");
        return true;
    }
}