# Hair Salon Clientelle Tracker

#### Keisha Hepner

#### A clientelle tracker for stylists

## Technologies Used

* C#
* MySql
* HTML
* .NET 5
* Entity
* ASP.NET Core MVC
* JavaScript

## Description

This application allows a salon to add stylists with details including: name, specialty and hours. It allows a salon to add clients to stylists with the details: name, phone number, appointment date, and service needed. It suports edit and delete functionality of both stylists and clients.

## Setup/Installation Requirements

* REQUIRES: .NET 5 & MySql

* Clone repository with the link https://github.com/KeishaMarie/HairSalon
* Navigate to project folder
* Import keisha_hepner.sql as a new database with the name keisha_hepner
* Create a fle names appsettings.json in the project folder 'HairSalon'

* Add the following code in your appsettings.json file and update it with your UID and password.

{ <br>
  "ConnectionStrings": { <br>
      "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=YOURUSERNAME;pwd=YOURPASSWORD;" <br>
  } <br>
}

* Run dotnet restore
* Run dotnet build
* Run dotnet run to run live server


Copyright (c) <2022> <Keisha Hepner>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.