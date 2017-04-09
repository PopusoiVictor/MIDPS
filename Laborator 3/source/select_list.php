<?php
// Liste select multiple - www.marplo.net/ajax/

// Aici adaugati datele dv. pt. conectare la baza de date MySQL
$server = 'localhost';
$user = 'root';
$pass = '';
$dbase = 'smotramd';

// Aici adaugati numele tabelului, apoi coloanele pt. lista select, in ordinea lor
// Adaugati null in loc de 'links', daca nu vreti sa fie afisate si datele din ea
$table = 'masini';
$ar_cols = array('Marca', 'Model', 'Anul', 'Pret');

if(!isset($_SESSION)) session_start();
header('Content-type: text/html; charset=utf-8');

$preid = 'slo_';        // un prefix folosit la ID-ul elementelor in care Ajax va adauga <select>
$col = $ar_cols[0];     // variabila in care e retinuta coloana ce trebuie selectata
$re_html = '';          // va retine codul html returnat de script

// daca sunt date primite prin POST, cu index 'col' si 'wval'
if(isset($_POST['col']) && isset($_POST['wval'])) {
  // seteaza $col ce trebuie selectat si valoarea pt WHERE (sterge tag-uri si spatii exterioare din $_POST)
  $col = trim(strip_tags($_POST['col']));
  $wval = trim(strip_tags($_POST['wval']));
}

$key = array_search($col, $ar_cols);    // obtine index-ul asociat cu valoarea lui $col din $ar_cols
$wcol = $key===0 ? $col : $ar_cols[$key-1];  // obtine coloana pt conditia WHERE
  
// obtine urmatorul element din $ar_cols (folosit la functia onchange() din tag-ul <select>)
$last_key = count($ar_cols)-1;
$next_col = $key<$last_key ? $ar_cols[$key+1] : '';

$conn = new mysqli($server, $user, $pass, $dbase);  // conectare la baza de date MySQL

if(mysqli_connect_errno()) { exit('Eroare la cenexiune: '. mysqli_connect_error()); }  // verificare conexiune

$_SESSION['ar_cols'][$wcol] = isset($wval) ? $conn->real_escape_string($wval) : $wcol; //retine in SESSION coloana si valoarea ei pt WHERE

// setare array cu datele conditiei WHERE (coloana=valoare) pt. instructiunea SELECT
for($i=1; $i<=$key; $i++) {
  $ar_where[] = '`'. $ar_cols[$i-1]. "`='". $_SESSION['ar_cols'][$ar_cols[$i-1]] ."'";
}

// defineste sirul cu conditia WHERE, apoi instructiunea SELECT
$where = isset($ar_where) ? ' WHERE '. implode($ar_where, ' AND ') : '';
$sql = "SELECT DISTINCT `$col` FROM `$table`".$where;

$resql = $conn->query($sql);    // trimite comanda la serverul MySQL

// daca $resql contine cel putin un rand
if ($resql->num_rows > 0) {
  // seteaza evenimentul "onchange" care se adauga in <select>
  $onchg = $next_col!==null ? " onchange=\"ajaxReq('$next_col', this.value);\"" : '';

  // seteaza tag-ul pt lista select, daca nu e ultima coloana
  if($col!=$ar_cols[$last_key]) $re_html = $col. ': <select name="'. $col. '"'. $onchg. '><option>- - -</option>';

  while($row = $resql->fetch_assoc()) {
    // daca e ultima coloana, returneaza datele din ea, altfel le adauga in tag-uri OPTION
    if($col==$ar_cols[$last_key]) $re_html .= '<br/>'. $row[$col];
    else $re_html .= '<option value="'. $row[$col]. '">'. $row[$col]. '</option>';
  }

  if($col!=$ar_cols[$last_key]) $re_html .= '</select> ';    // inchide lista Select
}
else { $re_html = '0 rezultate'; }

$conn->close();

// daca coloana selectata, $col, e primul element in $ar_cols
if($col==$ar_cols[0]) {
  // adauga tag-uri SPAN (sau DIV la ultimul element) unde Ajax va adauga listele <select>
  // cu ID in fiecare SPAN, cu numele coloanelor adaugate in $ar_cols
  for($i=1; $i<count($ar_cols); $i++) {
    if($ar_cols[$i]===null) continue;
    if($i==$last_key) $re_html .= '<div id="'. $preid.$ar_cols[$i]. '"> </div>';
    else $re_html .= '<span id="'. $preid.$ar_cols[$i]. '"> </span>';
  }

  // adauga coloanele in JS (folosite in removeLists() ca sa stearga listele select afisate, cand se alege alta optiune)
  $re_html .= '<script type="text/javascript">var ar_cols = '.json_encode($ar_cols).'; var preid = "'. $preid. '";</script>';
}
else echo $re_html;