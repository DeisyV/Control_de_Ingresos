<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlGastosAppWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!DOCTYPE html><!--informa al navegador cual version de html se esta usando-->

<html lang="es"><!--definir el lenguage, traduce el idioma-->

    <head>
        <meta charset="UTF-8"><!--permite caracteres en el navegador, definir el diccionario-->
        <meta name="viewport" content="width=device-width"><!--adaptar para dispositivos moviles-->
        <title>Control de Gastos</title><!--nombre de la ventana-->
        <link rel="stylesheet" href="reset.css">
        <link rel="stylesheet" href="style.css"><!--stylesheet es hoja de estilo-->
        <link href="https://fonts.googleapis.com/css2?family=Montserrat:wght@300&display=swap" rel="stylesheet">
    </head>

    <body>
        <header>
            <div class="caja">
                <h1><img src="img/bolsa$1.png"></h1>
                
            </div>
        </header>

        <main>
            <section class="principal">

                <h2 class="titulo-principal"><strong><em>¿Qué son los Ingresos?</em></strong></h2>

              

                <p>Es el dinero que recibes de distintas maneras. Los salarios, las rentas de arriendos, las ganancias obtenidas en un negocio y las herencias, son claros ejemplos de ingresos.</p>
                
                         

            </section>

            <section class="diferenciales">

                <h2 class="titulo-principal"><strong><em>¿Qué son los Egresos?</em></strong></h2>

                <div class="contenido-egresos">
                    <!--diferenciales-->
                    <p>A diferencia de los ingresos, los <strong>egresos</strong> son todo aquello que <strong>gastas</strong> en un periodo de tiempo definido. Por ejemplo:</p>
                    <ul class="lista-egresos">
                        <li class="items"><strong>Préstamos</strong></li>
                        <li class="items"><strong>Servicios de entretenimiento y/o comunicación</strong></li>
                        <li class="items"><strong>Transporte:</strong></li>
                        <li class="items"><strong>Servicios Basicos del Hogar</strong></li>
                        <li class="items"><strong>Alimentación y Cuidado personal</strong></li>
                        <li class="items"><strong>Servicios de Salud</strong></li>
                        <li class="items"><strong>Educación</strong></li>
                    </ul><img src="diferenciales/diferenciales.jpg" class="imagen-diferenciales">
                </div>
            </section>

        </main>



        


    </body>



</html>


 
   
</asp:Content>
