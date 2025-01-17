The Tagor.NET API client component implements the Tagor API v2.0 API (Bailiff software developed in Belgium by a company called Organi). The component requires a Tagor server and API key to connect to. 

The code (in the TagorClient folder) is entirely generated by the [OpenAPI Generator](https://openapi-generator.tech) project.
Recreate this using this command
```
openapi-generator-cli generate -i TagorApi.yaml -g csharp -o TagorClient --additional-properties=packageName=TagorClient
```

The documentation for the api is very complete and can be found under [`TagorClient/docs`](https://github.com/GDW-Innovations/Tagor.NET/blob/main/TagorClient/README.md)

IMPORTANT: This code comes as provided, with no support or guarantees. This code is not owned, published or supported by Organi but is managed by GDW Innovations.

```
 ___________ _    _   _____                            _   _                 
|  __ \  _  \ |  | | |_   _|                          | | (_)                
| |  \/ | | | |  | |   | | _ __  _ __   _____   ____ _| |_ _  ___  _ __  ___ 
| | __| | | | |/\| |   | || '_ \| '_ \ / _ \ \ / / _` | __| |/ _ \| '_ \/ __|
| |_\ \ |/ /\  /\  /  _| || | | | | | | (_) \ V / (_| | |_| | (_) | | | \__ \
 \____/___/  \/  \/   \___/_| |_|_| |_|\___/ \_/ \__,_|\__|_|\___/|_| |_|___/
                                                                             
```                                                                          

                                                                     

                                                                                      
                                                                                      
