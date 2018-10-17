
#### This is a starter kit for Asp.net core MVC and Api with PostgresSql and Docker support

To Run run the application, clone the Repository in a workdir.

After cloning the repository into a workdir, install docker if you dont have it installed on you machine already.

Checkout how to install docker [here](https://docs.docker.com/install/).

To run the application, we need to pull and build the postgesSQL image from docker hub, run the following command to pull the image

    docker pull postgres
    
After pulling the image, go ahead and build the image with the following command

    docker run -d --name my-postgres -e POSTGRES_PASSWORD=<PASSWORD> postgres

Note: the <Password> placeholder is for the desired password for your postgres database.
  
Before we build the Application, We need to do two things.

First, we need to generate our migrations file for our database schema. To do this run the following command.

     dotnet ef migrations add <MIGRATIONNAME>

Secondly, we need to change the postgres password in the appsettings.production.json file in our StarterKit.Web project to the password set when running the postgres command.

To run the application, execute the following command
    docker run -d -p 8080:80 -e PG_DATABASE_USER=postgres -e PG_DATABASE_PASS=emmanuel11 -e PG_DATABASE_HOST=postgres -e PG_DATABASE_NAME=StarterKitDB --name starterkit --link my-postgres:postgres starterkit
    
Erika!!! open your browser and go to http://localhost:8080/
