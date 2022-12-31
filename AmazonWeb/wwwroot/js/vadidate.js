{
    let inputElements = document.getElementsByClassName("input-user");
    // console.log(inputElements);

    let btnRegister = document.getElementById("btn-register");
    btnRegister.onclick = function (e) {
        // console.log(btnRegister);

        for (let i = 0; i < inputElements.length; ++i) {
            // console.log(inputElements[i].value)
            let messageDefaultElement = inputElements[i].parentElement.querySelector(".message-default");
            if (Boolean(messageDefaultElement)) {
                messageDefaultElement.style.display = "none";
            }
            if (!Boolean(inputElements[i].value)) {
                // console.log(Boolean(inputElements[i].value));
                // console.log(messageElements)
                let messageElements = inputElements[i].parentElement.querySelector(".message");

                inputElements[i].style.border = "1px solid red"
                inputElements[i].style.boxShadow = "0 0 3px 2px #fdbdbd"
                messageElements.style.display = "block";

            } else {
                // console.log(inputElements[i].id);
                let idInput = inputElements[i].id;
                switch (idInput) {
                    case "name":
                        //call isYourName :
                        // console.log(inputYourName);
                        if (!isYourName(inputElements[i].value)) {
                            controlMessage("name", "Your name not contains numbers or special character");
                        }
                        break;
                    case "email":
                        //call isEmail :
                        if (!isEmail(inputElements[i].value)) {
                            controlMessage("email", "Invalid Email");
                        }
                        break;
                    case "password":
                        //call isPassword
                        if (!isPassword(inputElements[i].value)) {
                            controlMessage("password", "Password contains minimum eight characters, at least one letter and one number");
                        }
                        break;

                    case "repassword":
                        //call isRePassword
                        let password = document.getElementById("password");
                        if (!(password.value == inputElements[i].value)) {

                            controlMessage("repassword", "incorrect password");
                        }
                        break;

                }


            }
        }
    }

    // code event blur input
    for (let i = 0; i < inputElements.length; ++i) {
        inputElements[i].onfocus = function (e) {
            // console.log(inputElements[i]);
            let field = inputElements[i].parentElement;
            let message = field.querySelector(".message");
            inputElements[i].style.border = "1px solid #e77600";
            inputElements[i].style.boxShadow = "0 0 3px 2px rgb(228 121 17 / 50%)";
            message.style.display = "none"
        }
    }


    //function control message :
    function controlMessage(idField, content) {
        let input = document.getElementById(idField);
        // console.log(inputYourName);

        let messageContent = input.parentElement.querySelector(".message-content");
        let message = input.parentElement.querySelector(".message");
        // console.log(message);
        input.style.border = "1px solid red"
        input.style.boxShadow = "0 0 3px 2px #fdbdbd"
        message.style.display = "block";
        // console.log(messageContent);
        messageContent.innerHTML = content;

    }

    //check your name : not contain number and specail characters
    function isSpecial(str) {
        var format = /^[!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?]*$/;

        if (str.match(format)) {
            return true;
        } else {
            return false;
        }
    }

    function isNumeric(value) {
        return /^-{0,1}\d+$/.test(value);
    }

    //check function :
    function isYourName(str) {
        for (let i = 0; i < str.length; ++i) {
            if (isSpecial(str[i]) || isNumeric(str[i])) {
                return false;
            } else {
                continue;
            }
        }

        return true;
    }

    //check email :
    function isEmail(mail) {
        if (/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/.test(mail)) {
            return (true)
        }
        return (false)
    }

    function isPassword(pass) {
        if (/^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$/.test(pass)) {
            return true
        }
        return false;
    }


}