
function myfunct() {

    var val1 = document.getElementById("email_textbox").value;
    var val2 = document.getElementById("usernaam_textbox").value;
    var val3 = document.getElementById("password_textbox").value;
    var val4 = document.getElementById("phone_textbox").value;

    if (val1 == "" && val2 == "" && val3 == "" && val4 == "") {

        document.getElementById("Label1").innerText = "*fill this field";
        document.getElementById("Label2").innerText = "*fill this field";
        document.getElementById("Label3").innerText = "*fill this field";
        document.getElementById("Label4").innerText = "*fill this field";

    }

    else if (val1 == "") {

        document.getElementById("Label1").innerText = "*fill this field";
    }

    else if (val2 == "") {

        document.getElementById("Label2").innerText = "*fill this field";
    }

    else if (val3 == "") {

        document.getElementById("Label3").innerText = "*fill this field";
    }

    else if (val4 == "") {

        document.getElementById("Label4").innerText = "*fill this field";
    }

    else {

        var counter = 0;

        for (var i = 0; i < val2.length; i++) {

            if (isFinite(val2[i])) {

                counter = counter + 1;
            }

        }

        if(counter <= 1){

            document.getElementById("Label2").innerText = "*Invalid UserName";
            return false;
        }

        else if( isNaN(val4) ){

            document.getElementById("Label4").innerText = "*Invalid Number";
            return false;
        }

       else if (counter >= 2 && isFinite(val4)) {

            return true;
        }

               

    }

}