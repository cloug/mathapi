# mathapi
ASP.NET 5 math sample service

Once deployed with CoreCLR / Kestrel, this service exposes a method that adds two integers. Maybe one day this project will evolve into a complete math API, but for now, it is only used as a sample for Docker experimentation.

Exemple of calling : http://127.0.0.1/api/Math/Ajouter?n&=2&n2=3

The associated Docker image can be found on https://github.com/jp-gouigoux/mathapi