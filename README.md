# mathapi
## ASP.NET 5 math sample service ##

This is a test service containing a simple Math API implemented in MVC 6 (ASP.NET 5), inside a Kestrel web server. It is created to show the Linux compatibility of the recent .NET Core.

Once deployed with CoreCLR / Kestrel, this service exposes a method that adds two integers. Maybe one day this project will evolve into a complete math API, but for now, it is only used as a sample for Docker experimentation.

The user can deploy by copying the src folder onto a CoreCLR install, or use the generated Docker image by running such a command :
 
    sudo docker run -t -d -p 80:5004 jpgouigoux/mathapi

When a container is launched, the API is exposed on port 5004 internally, under /api/Math. To call the service, one needs to use a URL corresponding to this example :

    curl http://127.0.0.1/api/Math/Ajouter?n1=2&n2=3

