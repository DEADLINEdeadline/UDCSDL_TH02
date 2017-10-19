<?php 
require_once 'init.php';

if ($currentUser['id'] == "")
{
        header('Location: index.php');
        exit();
}
if (!empty($_POST['stt']))
{
        upstatus($currentUser['id'],$_POST['stt']);
        header('Location: index.php');
        exit();
}
?>
<?php include 'header.php' ?>
<form method="POST">
   <div class="form-group">
       <label for="stt">Status</label>
       <textarea rows="4" cols="50" type="text" class="form-control" id="stt" name="stt"></textarea>
   </div>
   <button type="submit" class="btn btn-primary">Đăng</button>
</form>