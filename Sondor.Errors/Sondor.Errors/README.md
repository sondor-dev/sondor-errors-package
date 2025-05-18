# Sondor Errors
Sondor errors provides an easy way to manage errors, how they're handled and simplifying the process of raising, creating and customized clear
and easy to understand errors. Providing base custom exceptions, that apply to many common scenarios while encouraging the use of customized more
contextually clear exceptions.

## Base Exceptions
Use the base exceptions to create your own custom exceptions. The base exceptions are designed to be used as
a starting point for your own custom exceptions. The exceptions will automatically integrate with other Sondor packages.

| Name | Description |
| --- | --- |
| `EntityCreateFailedException` | The base exception for when an entity fails to be created. |
| `EntityDeleteFailedException` | The base exception for when an entity fails to be deleted. |
| `EntitNotFoundException` | The base exception for when an entity could not be found. |
| `EntityUpdateFailedException` | The base exception for when an entity fails to be updated. |
| `InvalidStateException` | The base exception for when a request, entity, parameters etc reaches an invalid state. |