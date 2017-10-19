<h3> ____ Status ____ </h3>
<?php require_once 'init.php' ?>
<?php require_once 'header.php' ?>
<?php
for ($i = 0; $i < 1000; $i++)
{
        $row = getstatus($i);
        if ($row != null)
        {
                echo "<div class=\"container\"><div class=\"panel panel-primary\"> <div class=\"panel-heading\">", $row['fullname'] ,"</div> <div class=\"panel-body\">", $row['content'] ,"</div></div></div>";
                echo '<h4></h4>';
        }
}
?>