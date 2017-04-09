// Liste select Multiple - www.marplo.net/ajax/

// functie utilizata la stergerea urmatoarelor liste deja afisate, cand se alege alta optiune
function removeLists(colid) {
  var z = 0;
  // sterge datele din elementele cu id-ul stocat in variabila "ar_cols"
  // incepand cu elementul al carui ID e in colid
  for(var i=1; i<ar_cols.length; i++) {
    if(ar_cols[i]==null) continue;
    if(ar_cols[i]==colid) z = 1;
    if(z==1) document.getElementById(preid+ar_cols[i]).innerHTML = '';
  }
}

// trimite date la un script php, prin POST, si afiseaza raspunsul primit
function ajaxReq(col, wval) {
  removeLists(col);   // sterge listele select deja afisate

  // daca valoarea lui wval nu e '- - -' sau '' (primul <option>)
  if(wval!='- - -' && wval!='') {
    var request = (window.XMLHttpRequest) ? new XMLHttpRequest() : new ActiveXObject('Microsoft.XMLHTTP');  //XMLHttpRequest instance
    var php_file = 'select_list.php';     // calea si numele fisierului php

    // creare perechi index=valoare cu datele ce vor fi trimise la server
    var  data_send = 'col='+col+'&wval='+wval;

    request.open('POST', php_file, true);  // seteaza cererea Ajax

    document.getElementById(preid+col).innerHTML = 'Incarcare...';   // notificare de incarcare

    // adauga header care sa transmita script-ului PHP sa recunoasca datele ca fiind transmise prin POST
    request.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
    request.send(data_send);   // apeleaza metoda send() cu data_send

    // Verifica starea cererii
    // Daca raspunsul e primit complet, il adauga in tag-ul cu id-ul din "col"
    request.onreadystatechange = function() {
      if (request.readyState==4) {
        document.getElementById(preid+col).innerHTML = request.responseText;
      }
    }
  }
}