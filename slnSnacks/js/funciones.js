$(function(){
    

            //FUNCION QUE SUMA UN ELEMENTO AL TEXTO CANTIDAD
    $("#mas").click(function(){

        var cant = $("#ContentPlaceHolder1_txtCantidad").val();
        var numero = 0;

        if (cant == "") {
            numero = 1;
        }
        else {

            if (validarSiNumero(cant)) {
                numero = parseInt(cant);
                numero += 1;
            }
        }
        $("#ContentPlaceHolder1_txtCantidad").val(numero);
    });


    //FUNCION QUE RESTA UN ELEMENTO AL TEXTO CANTIDAD
     $("#menos").click(function(){

         var cant = $("#ContentPlaceHolder1_txtCantidad").val();
         var numero = 0;

         if (cant == "") {
             numero = 0;
         }
         else {

             if (validarSiNumero(cant)) {
                 numero = parseInt(cant);
                 
                 if (numero > 0) {
                     numero -= 1;
                 } else {
                     numero = 0;
                 }   
             }
         }
         $("#ContentPlaceHolder1_txtCantidad").val(numero);
     });

    // FUNCION QUE CAMBIA EL VALOR DE CANTIDAD CON EL MONTO REGISTRADO
     $("#ContentPlaceHolder1_txtCantidad").change(function () {
         
         var cant = $("#ContentPlaceHolder1_txtCantidad").val();
         var numero = 0;

         if (cant == "") {
             numero = 0;
             $("#ContentPlaceHolder1_txtCantidad").val(numero);
         }
         else {

             if (validarSiNumero(cant)) {
                 numero = parseInt(cant);

                 if (numero > 0) {
                     $("#ContentPlaceHolder1_txtCantidad").val(numero);
                 } else {
                     numero = 0;
                     $("#ContentPlaceHolder1_txtCantidad").val(numero);
                 }
            }else{
                 numero = 0;
                 $("#ContentPlaceHolder1_txtCantidad").val(numero);

             }
         }



     });





    //FUNCION QUE VALIDA SI UN TEXTO ES DE TIPO NUMERO
     function validarSiNumero(numero) {
         if (/^([0-9])*$/.test(numero)) {
             return true;
         } else {
             alert("'" + numero + "' no es una entrada válida");
             return false;
         }
            
     }


});