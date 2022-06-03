## Turkey city-district-town web service 

# What will this do for me?

It will allow you to access all the cities in Turkey, the districts of the cities, the neighborhood-village data of the districts on any server, free of charge and without having to save them on your computer.

# How is the design of the project?

In short, divide - divide - rule. Data extraction operations are in a separate class structure. The word checks (are there any spaces, capitalize all etc..) are in a separate place, the model, that is, the database is in another folder..

# Are there any links I can access?

Of course.

ASMX Web Service; <br>
-> https://api.kadircolak.com/Konum/SOAP/TurkeyLocation.asmx
JSON Web Service <br>
-> https://api.kadircolak.com/Konum/JSON/API/DeveloperInfo (Developer user info) <br>
-> https://api.kadircolak.com/Konum/JSON/API/ShowAllCity (Show all city) <br>
-> https://api.kadircolak.com/Konum/JSON/API/ShowDistrict?plate=34 (All districts in Istanbul) <br>
-> https://api.kadircolak.com/Konum/JSON/API/ShowTown?plate=34&district=BAŞAKŞEHİR  (All neighborhoods and villages in Başakşehir district of Istanbul city) <br>

# Where can I access the project's data source?

It will be shared as a new repository on my Github profile.

# What are the technologies used?

-> Microsoft SQL Server <br>
-> ASP.NET MVC <br>
-> HTML - CSS - JS <br>
-> ASMX Web Service <br>
-> Rest Full Apı (JSON) <br>
