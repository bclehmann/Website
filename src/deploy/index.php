<?php

function execPrint($command) {
    $result = array();
    exec($command, $result);
    print("<pre>");
    foreach ($result as $line) {
        print($line . "\n");
    }
    print("</pre>");
}

echo "<h1>PULL</h1>";
execPrint("git -C ../ pull https://github.com/ScottPlot/Website.git");

echo "<h1>STATUS</h1>";
execPrint("git status");
