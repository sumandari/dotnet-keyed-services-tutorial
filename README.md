## Using Keyed Services in WebApi Dependency Injection

- Checkout to commit sha `285a8588` to see the simple WebApi project without keyed services.
- Checkout to commit sha `54d51d00` to see the updated WebApi project with keyed services.

### Keyed Services Overview

In this project we have `IPersonRepository` interface with two implementations: `StudentRepository` 
and `TeacherRepository`. Each implementation is registered in the DI container with a unique key.


The way to update the project to use keyed service is by updating `builder.Services.AddScoped` 
to `builder.Services.AddedKeyedScoped`. Check the detail 
in [github diff](https://github.com/sumandari/dotnet-keyed-services-tutorial/commit/54d51d00a604535a35fdad5d96f79c1bd72c3b0d#diff-980ebc65d36a9356811dd16c1106a94fb0fff6b63092ff2f4ef85d8f2f6148b8R7).

And add the `key` in the controller constructor to specify which implementation to use. 
Check the detail in [github diff](https://github.com/sumandari/dotnet-keyed-services-tutorial/commit/54d51d00a604535a35fdad5d96f79c1bd72c3b0d#diff-82734d0e2075ea21a0502c5f13b7f29f1546051b8157a45776acd3db2c53f7eeR14)