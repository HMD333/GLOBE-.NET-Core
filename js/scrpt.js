var home_el = document.getElementById("HOME");

var news_el = document.getElementById("NEWS");

var politics_el = document.getElementById("POLITICS");

var business_el = document.getElementById("BUSINESS");

var sport_el = document.getElementById("SPORT");

var technology_el = document.getElementById("TECHNOLOGY");

// 

var Home_el = document.getElementById("Home");

var News_el = document.getElementById("News");

var Politics_el = document.getElementById("Politics");

var Business_el = document.getElementById("Business");

var Sport_el = document.getElementById("Sport");

var Technology_el = document.getElementById("Technology");


Home_el.addEventListener("click",function(){
    home_el.style.display = "block";
    news_el.style.display = "none";
    politics_el.style.display = "none";
    business_el.style.display = "none";
    sport_el.style.display = "none";
    technology_el.style.display = "none";


    console.log("Home")
    Home_el.setAttribute("active", "true");
    News_el.setAttribute("active", "false");
    Politics_el.setAttribute("active", "false");
    Business_el.setAttribute("active", "false");
    Sport_el.setAttribute("active", "false");
    Technology_el.setAttribute("active", "false");
});

News_el.addEventListener("click",function(){
    home_el.style.display = "none";
    news_el.style.display = "block";
    politics_el.style.display = "none";
    business_el.style.display = "none";
    sport_el.style.display = "none";
    technology_el.style.display = "none";


    Home_el.setAttribute("active", "false");
    News_el.setAttribute("active", "true");
    Politics_el.setAttribute("active", "false");
    Business_el.setAttribute("active", "false");
    Sport_el.setAttribute("active", "false");
    Technology_el.setAttribute("active", "false");
});

Politics_el.addEventListener("click",function(){
    home_el.style.display = "none";
    news_el.style.display = "none";
    politics_el.style.display = "block";
    business_el.style.display = "none";
    sport_el.style.display = "none";
    technology_el.style.display = "none";


    Home_el.setAttribute("active", "false");
    News_el.setAttribute("active", "false");
    Politics_el.setAttribute("active", "true");
    Business_el.setAttribute("active", "false");
    Sport_el.setAttribute("active", "false");
    Technology_el.setAttribute("active", "false");
});

Business_el.addEventListener("click",function(){
    home_el.style.display = "none";
    news_el.style.display = "none";
    politics_el.style.display = "none";
    business_el.style.display = "block";
    sport_el.style.display = "none";
    technology_el.style.display = "none";


    Home_el.setAttribute("active", "false");
    News_el.setAttribute("active", "false");
    Politics_el.setAttribute("active", "false");
    Business_el.setAttribute("active", "true");
    Sport_el.setAttribute("active", "false");
    Technology_el.setAttribute("active", "false");
});

Sport_el.addEventListener("click",function(){
    home_el.style.display = "none";
    news_el.style.display = "none";
    politics_el.style.display = "none";
    business_el.style.display = "none";
    sport_el.style.display = "block";
    technology_el.style.display = "none";


    Home_el.setAttribute("active", "false");
    News_el.setAttribute("active", "false");
    Politics_el.setAttribute("active", "false");
    Business_el.setAttribute("active", "false");
    Sport_el.setAttribute("active", "true");
    Technology_el.setAttribute("active", "false");
});

Technology_el.addEventListener("click",function(){
    home_el.style.display = "none";
    news_el.style.display = "none";
    politics_el.style.display = "none";
    business_el.style.display = "none";
    sport_el.style.display = "none";
    technology_el.style.display = "block";


    Home_el.setAttribute("active", "false");
    News_el.setAttribute("active", "false");
    Politics_el.setAttribute("active", "false");
    Business_el.setAttribute("active", "false");
    Sport_el.setAttribute("active", "false");
    Technology_el.setAttribute("active", "true");
});
