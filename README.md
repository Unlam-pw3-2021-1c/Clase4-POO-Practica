# Cuarta Clase de Práctica - "Programación Orientada a Objetos"

En esta clase vimos el siguiente ejercicio repasando los conceptos de **Herencia, Clase abstracta, Interfaz, Polimorfismo**:

## Enunciado
El equipo de programadores del juego "El Gran Director Técnico" tiene el desafío de desarrollar un nuevo premio llamado "La batalla de los penales", donde ganará el DT que posea más puntos basándose en el siguiente cálculo:

_[Puntos batalla de los penales] = [Puntos de arquero] + [Puntos de delantero1] + [Puntos de delantero2]
**( * )** [Puntos de arquero] = [Cant de penales atajados] * 100
**( * )** [Puntos de delantero] = [Cant de penales convertidos] * 75_

**( * )** Si el jugador fue expulsado se debe restar 50 puntos

La funcionalidad identificada es la siguiente:
1. **Pantalla de alta de Arquero**, con los campos: Nombre, Apellido, Expulsado (Verdadero/Falso), Penales atajados y un boton "Crear Arquero"
2. **Pantalla de alta de Delantero**, con los campos: : Nombre, Apellido, Expulsado (Verdadero/Falso), Penales convertidos "Crear Delantero"
3. **Pantalla de alta de DT**, con los campos:  Nombre de usuario, Arquero, Delantero1, Delantero2 "Crear"
4. **Pantalla de lista de todos los DTs** ordenada alfabéticamente por Nombre de usuario, con los campos: Nombre de usuario, Puntos batalla de los penales
5. **Pantalla Ganador del premio “batalla de los penales”**, visualizando:
    **DT Ganador:** [Nombre de usuario]
    **Puntos Totales:** [Puntos batalla de los penales]
    **Arquero:** [Apellido], [Nombre] ([Puntos de arquero])
    **Delantero1:** [Apellido], [Nombre] ([Puntos de delantero])
    **Delantero2:** [Apellido], [Nombre] ([Puntos de delantero])

## Tareas a realizar
1. Identifique las entidades y potenciales clases del enunciado
2. Identifique las propiedades de cada entidad
3. Identifique si utilizar herencia y/o interfaces para su modelo mejoraría su análisis.
4. Cree una solución llamada "Clase4-Intro-a-POO" y un proyecto MVC Vacio "Clase4-Intro-a-POO " 
5. Cree las Vistas, Controladores, Modelos, Servicios, Clases e Interfaces necesarias para resolver el enunciado.