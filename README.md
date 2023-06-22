# OnionCrafter.Features

[![NuGet](https://img.shields.io/nuget/v/OnionCrafter.Feature.svg)](https://www.nuget.org/packages/OnionCrafter.Feature/)

![](https://github.com/Dtopiast/OnionCrafter.Feature/blob/main/Images/Logo.png)

OnionCrafter.Features es una librería que proporciona un conjunto de clases base mínimas para habilitar la implementación rápida y segura de controladores (handlers), comportamientos de pipeline (pipeline behaviors) y otros componentes necesarios dentro de una arquitectura onion. Esta librería utiliza MediatR para implementar el patrón Mediator.

## Descripción

OnionCrafter.Features es una librería diseñada para simplificar el desarrollo en una arquitectura onion, proporcionando clases base que contienen la lógica común necesaria para los controladores, comportamientos de pipeline y otros componentes. Esto permite a los desarrolladores centrarse en la implementación específica de las características (features) de su aplicación, en lugar de preocuparse por la estructura y la lógica repetitiva de la arquitectura.

## Características

- Implementación rápida y segura: OnionCrafter.Features ofrece clases base que permiten una implementación rápida y segura de controladores, comportamientos de pipeline y otros componentes necesarios en una arquitectura onion.

- Utilización del patrón Mediator: La librería utiliza MediatR para implementar el patrón Mediator, lo que facilita la comunicación y el flujo de datos entre los distintos componentes de la aplicación.

- Simplificación del desarrollo: Al proporcionar una base sólida y consistente, OnionCrafter.Features reduce la cantidad de código repetitivo que los desarrolladores deben escribir, lo que acelera el proceso de desarrollo y reduce la posibilidad de errores.

- Flexibilidad y extensibilidad: Las clases base de OnionCrafter.Features se pueden personalizar y extender según las necesidades específicas de cada proyecto, lo que permite una mayor flexibilidad en el diseño de la aplicación.

## Tecnologías utilizadas

OnionCrafter.Features utiliza las siguientes tecnologías:

- MediatR: Una librería que implementa el patrón Mediator y simplifica la comunicación entre los distintos componentes de una aplicación.
- AutoMapper: Una libreria para los mapeos automaticos.

## Instalación

Para instalar OnionCrafter.Features, puedes utilizar el Administrador de paquetes NuGet o descargar el paquete desde GitHub.

### Administrador de paquetes NuGet

```
Install-Package OnionCrafter.Features
```

### Descarga desde GitHub

Puedes descargar el paquete desde la sección de [releases](https://github.com/tu-usuario/onioncrafter.features/releases) en GitHub.

## Uso

Para utilizar OnionCrafter.Features en tu proyecto, agrega la referencia al paquete y comienza a heredar de las clases base proporcionadas. Utiliza MediatR para gestionar la comunicación entre los distintos componentes de tu aplicación.

## Contribuciones

Si deseas contribuir con el proyecto, por favor lee nuestras [directrices de contribución](CONTRIBUTING.md) para obtener más información.

## Licencia

Este proyecto está

 licenciado bajo la Licencia Mozilla Public License 2 (MPL 2) - lee el archivo [LICENSE](LICENSE.txt) para más detalles.
