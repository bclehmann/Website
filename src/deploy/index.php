<html>

<head>
    <style>
        body {
            background-color: #000000;
            color: #FFFFFF;
            margin: 2em;
        }

        pre {
            font-size: 1.5em;
            color: #00FF00;
        }
    </style>
</head>

<body>
    <?php

    $isAuthenticated = false;
    echo "<pre>";
    if ($isAuthenticated) {
        system('../../deploy.sh');
    } else {
        echo "ERROR: deployment requires authentication";
    }
    echo "</pre>";

    ?>
</body>

</html>