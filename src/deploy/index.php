<?php

// Ensure root files are accessible (they aren't in docker)
$canAccessRoot = file_exists('../../deploy.sh');
if ($canAccessRoot == false) {
    echo "Cannot access root folder (script does not work in Docker)";
    die();
}

// Get authorization header from Apache
$headers = apache_request_headers();
if (!isset($headers['Authorization'])) {
    echo "Authorization Required";
    die();
}

// Compare given token vs one on disk
$givenToken = substr($headers['Authorization'], 7);
$realToken = trim(file_get_contents('../../api.key'));
if ($givenToken == $realToken) {
    system('../../deploy.sh');
} else {
    echo "Authorization Failed";
}
