<?php

// Ensure root files are accessible
if (file_exists('../../api.key') == false) {
    echo "ERROR: api.key does not exist";
    die();
}

// Get authorization header from Apache
$headers = apache_request_headers();
if (!isset($headers['Authorization'])) {
    echo "ERROR: Authorization Required";
    die();
}

// Compare given token vs one on disk
$givenToken = substr($headers['Authorization'], 7);
$realToken = trim(file_get_contents('../../api.key'));
if ($givenToken == $realToken) {
    system('../../deploy.sh');
} else {
    echo "ERROR: Authorization Failed";
}
