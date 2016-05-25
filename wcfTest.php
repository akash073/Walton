<?php

//echo phpinfo();

$client = new SoapClient('http://localhost:8090/?wsdl');
//$client = new SoapClient('http://localhost:13100/Service1.svc?wsdl');
$value=array('value'=>100000);
$retval = $client->GetData($value);

print_r($retval);
?>