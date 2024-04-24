//nav items

var Home_el = document.getElementById("Home");

var News_el = document.getElementById("News");

var Politics_el = document.getElementById("Politics");

var Health_el = document.getElementById("Health");

var Sport_el = document.getElementById("Sport");

var Technology_el = document.getElementById("Technology");

var not_loged = document.getElementById("nav_login");

var loged = document.getElementById("nav_logedin");

var img = document.getElementById("img");

//acount

var Acount_el = document.getElementById("acount");

var user_acount_popup_el = document.getElementById("USER_ACOUNT_POPUP");

var admen_acount_popup_el = document.getElementById("ADMEN_ACOUNT_POPUP");

var auther_acount_popup_el = document.getElementById("AUTHER_ACOUNT_POPUP");

var logoicon_el = document.getElementById("logoicon");

//main contaners

var home_el = document.getElementById("HOME");

var news_el = document.getElementById("NEWS");

var politics_el = document.getElementById("POLITICS");

var health_el = document.getElementById("HEALTH");

var sport_el = document.getElementById("SPORT");

var technology_el = document.getElementById("TECHNOLOGY");

var sarch_el = document.getElementById("SARCH");

var log_in_el = document.getElementById("LOGIN");

var favuret_el = document.getElementById("FAVURET");

var create_contant_el = document.getElementById("CREATE_CONTANT");

var your_contant_el = document.getElementById("YOUR_CONTANT");

var create_account_el = document.getElementById("CREATE_ACCOUNT");

var edit_account_el = document.getElementById("EDIT_ACCONTE");

var fav_Card_sp_el = document.getElementById("fav_Card_sp");

var fav_Card_po_el = document.getElementById("fav_Card_po");

var fav_Card_he_el = document.getElementById("fav_Card_he");

var fav_Card_te_el = document.getElementById("fav_Card_te");

let RB_el = document.getElementsByName("fav_Card_rb");

//popup sing up & login 

var popup_el = document.getElementById("popup");

var SINGUP_el = document.getElementById("SingUP");

var LogIN_el = document.getElementById("LogIN");

function Home_active(){
    home_el.style.display = "block";
    news_el.style.display = "none";
    politics_el.style.display = "none";
    health_el.style.display = "none";
    sport_el.style.display = "none";
    technology_el.style.display = "none";
    sarch_el.style.display = "none";
    favuret_el.style.display = "none";
    create_contant_el.style.display = "none";
    your_contant_el.style.display = "none";
    create_account_el.style.display = "none";
    edit_account_el.style.display = "none";
    


    Home_el.setAttribute("active", "true");
    News_el.setAttribute("active", "false");
    Politics_el.setAttribute("active", "false");
    Health_el.setAttribute("active", "false");
    Sport_el.setAttribute("active", "false");
    Technology_el.setAttribute("active", "false");
};

function News_active(){
    favuret_el.style.display = "none";
    create_contant_el.style.display = "none";
    your_contant_el.style.display = "none";
    create_account_el.style.display = "none";
    edit_account_el.style.display = "none";


    Home_el.setAttribute("active", "false");
    News_el.setAttribute("active", "true");
    Politics_el.setAttribute("active", "false");
    Health_el.setAttribute("active", "false");
    Sport_el.setAttribute("active", "false");
    Technology_el.setAttribute("active", "false");
};

function Politics_active(){
    favuret_el.style.display = "none";
    create_contant_el.style.display = "none";
    your_contant_el.style.display = "none";
    create_account_el.style.display = "none";
    edit_account_el.style.display = "none";


    Home_el.setAttribute("active", "false");
    News_el.setAttribute("active", "false");
    Politics_el.setAttribute("active", "true");
    Health_el.setAttribute("active", "false");
    Sport_el.setAttribute("active", "false");
    Technology_el.setAttribute("active", "false");
};

function Health_active(){
    favuret_el.style.display = "none";
    create_contant_el.style.display = "none";
    your_contant_el.style.display = "none";
    create_account_el.style.display = "none";
    edit_account_el.style.display = "none";


    Home_el.setAttribute("active", "false");
    News_el.setAttribute("active", "false");
    Politics_el.setAttribute("active", "false");
    Health_el.setAttribute("active", "true");
    Sport_el.setAttribute("active", "false");
    Technology_el.setAttribute("active", "false");
};

function Sport_active(){
    favuret_el.style.display = "none";
    create_contant_el.style.display = "none";
    your_contant_el.style.display = "none";
    create_account_el.style.display = "none";
    edit_account_el.style.display = "none";


    Home_el.setAttribute("active", "false");
    News_el.setAttribute("active", "false");
    Politics_el.setAttribute("active", "false");
    Health_el.setAttribute("active", "false");
    Sport_el.setAttribute("active", "true");
    Technology_el.setAttribute("active", "false");
};

function Technology_active(){
    favuret_el.style.display = "none";
    create_contant_el.style.display = "none";
    your_contant_el.style.display = "none";
    create_account_el.style.display = "none";


    Home_el.setAttribute("active", "false");
    News_el.setAttribute("active", "false");
    Politics_el.setAttribute("active", "false");
    Health_el.setAttribute("active", "false");
    Sport_el.setAttribute("active", "false");
    Technology_el.setAttribute("active", "true");
};

function Sarch() {
    favuret_el.style.display = "none";
    create_contant_el.style.display = "none";
    your_contant_el.style.display = "none";
    create_account_el.style.display = "none";
    edit_account_el.style.display = "none";

    Home_el.setAttribute("active", "false");
    News_el.setAttribute("active", "false");
    Politics_el.setAttribute("active", "false");
    Health_el.setAttribute("active", "false");
    Sport_el.setAttribute("active", "false");
    Technology_el.setAttribute("active", "false");
};

function Acount_altrat(){
    Close_acount_popup()

    Home_active()
    home_el.style.display = "none";
    edit_account_el.style.display = "block";


    Home_el.setAttribute("active", "false");
};

function Favuret(){
    Close_acount_popup()

    Home_active()
    home_el.style.display = "none";
    favuret_el.style.display = "block";


    Home_el.setAttribute("active", "false");
};


function Create_Contant(){
    Close_acount_popup()
    
    Home_active()
    home_el.style.display = "none";
    create_contant_el.style.display = "block";


    Home_el.setAttribute("active", "false");
};

function Your_Contant(){
    Close_acount_popup()
    
    Home_active()
    home_el.style.display = "none";
    your_contant_el.style.display = "block";


    Home_el.setAttribute("active", "false");
};

function Create_Accont(){
    Close_acount_popup()
    
    Home_active()
    home_el.style.display = "none";
    create_account_el.style.display = "block";


    Home_el.setAttribute("active", "false");
};

function Ad_Acount_active(){
    admen_acount_popup_el.style.display = "block";
};

function Us_Acount_active(){
    user_acount_popup_el.style.display = "block";
};

function Au_Acount_active(){
    auther_acount_popup_el.style.display = "block";
};

function Close_popup(){
    popup_el.style.display = "none";
};

function Close_acount_popup(){
    admen_acount_popup_el.style.display = "none";
    auther_acount_popup_el.style.display = "none";
    user_acount_popup_el.style.display = "none";
};

log_in_el.addEventListener("click",function(){
    popup_el.style.display = "block";
});

function Register(){
    SINGUP_el.style.display = "block";
    LogIN_el.style.display = "none";
};

function use_the_acount(){
    SINGUP_el.style.display = "none";
    LogIN_el.style.display = "block";
};

function in_acount(){
    loged.style.display = "block";
    not_loged.style.display = "none";
    Close_popup()
};

function logout(){
    loged.style.display = "none";
    not_loged.style.display = "block";
    Close_acount_popup()
    Home_active()
};

function logout_icon(src){
    logoicon_el.src = src
};

RB_el.forEach(radio => {
    radio.addEventListener("change",function(){
        if(radio.value == "Spore"){
            fav_Card_sp_el.setAttribute("active", "true");
            fav_Card_po_el.setAttribute("active", "false");
            fav_Card_he_el.setAttribute("active", "false");
            fav_Card_te_el.setAttribute("active", "false");
        }
        else if(radio.value == "Politics"){
            fav_Card_sp_el.setAttribute("active", "false");
            fav_Card_po_el.setAttribute("active", "true");
            fav_Card_he_el.setAttribute("active", "false");
            fav_Card_te_el.setAttribute("active", "false");
        }
        else if(radio.value == "Health"){
            fav_Card_sp_el.setAttribute("active", "false");
            fav_Card_po_el.setAttribute("active", "false");
            fav_Card_he_el.setAttribute("active", "true");
            fav_Card_te_el.setAttribute("active", "false");
        }
        else if(radio.value == "Technology"){
            fav_Card_sp_el.setAttribute("active", "false");
            fav_Card_po_el.setAttribute("active", "false");
            fav_Card_he_el.setAttribute("active", "false");
            fav_Card_te_el.setAttribute("active", "true");
        }
    })
    
});

const inputElements = document.querySelectorAll('.pop_SingUP input');

inputElements.forEach(input => {
    input.addEventListener('input', function () {
        if (input.value.trim() !== '') {
            input.classList.add('filled');
        } else {
            input.classList.remove('filled');
        }
    });
});

