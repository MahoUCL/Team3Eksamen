# Intro
## Forklaring af projekter i denne solution

Vi har to forskellige projekter i vores solution. Dette er fordi vi ændrede vores arkitektur midtvejs af sikkerhedsmæssige grunde. Vi nåede dog ikke at sætte funktionaliteten af vores login-system op i det nye projekt. Derfor har vi valgt at inkludere det tidligere projekt for at demonstrere denne funktionalitet. Funktionaliteten i det tidligere projekt består af, at man ikke kan tilgå banedesigneren uden at være logget ind.

### Banedesignere:

Dette projekt består også af to forskellige Banedesignere, da vi gerne ville afprøve forskellige måder at lave løsningen på.  
Den ene er skrevet i Javascript og demonstrerer mere komplet funktionalitet. Denne Banedesigner har både mere elegant errorhandling og udnytter vores viden om HTTP. 

Den anden er skrevet i C#, men er ikke funktionel. Vi ville forsøge at genopbygge logikken i C# for nemmere at kunne genbruge objekter og klasser på tværs af hele systemet, som blazor tilbyder.



 


# How to

## Step 1 Databasen

### Opsætning af databasen:

For windows: 
1. Åben CMD
2. Opret en lokal SQL server med kommando: ```sqllocaldb c localdb1```

Nu er databasen klar til sammen med connectionString fra projektet

## Step 2 Entitiy Framework

### Åben solution i Visual Studio
Det tidligere og det nye projekt anvender to forskellige connection-strings, men begge to forbinder til databaseserveren, som du lige har oprettet.
Derfor er det vigtigt at gøre, som der står nedenstående for at sikre at både det tidligere og det nye projekt virker som det skal.

Unload HundeRally.Wasm, HundeRally.WebUI og HundeRally.WebUI.Client.
#### Med kun HundeRally.Api loaded:

1. Åben Package Manager Console
2. Tjek at HundeRally.Api er valgt som default project i dropdown menuen
3. Skriv: ```Update-database```

Unload HundeRally.Api og hold HundeRally.Wasm unloaded.
#### Med kun HundeRally.WebUI og HundeRally.WebUI.Client loaded:

1. Åben Package Manager Console
2. Tjek at HundeRally.WebUI er valgt som default project i dropdown menuen
3. Skriv: ```Update-database```


## Åbning af projekterne

Nu da databasen er sat op for begge projekter, kan de åbnes og fungere hver for sig. Dette kræver at de korrekte projekter er loaded og at dit IDE starter fra de korrekte projekter.

### Banedesignerprojektet:

Load HundeRally.API og HundeRally.Wasm
Unload HundeRally.WebUI og HundeRally.WebUI.Client

Kør med multiple startup projects og inkluder de to loadede projekter.
![Multiple startup](https://github.com/MahoUCL/Team3Eksamen/assets/67104446/f7e4b67f-8ed5-4532-a1d3-ef743abaf539)


### Loginprojektet

Load HundeRally.WebUI og HundeRally.WebUI.Client
Unload HundeRally.API og HundeRally.Wasm

Kør med HundeRally.WebUI som startup project.


