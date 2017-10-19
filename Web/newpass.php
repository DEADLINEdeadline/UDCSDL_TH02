<?php 
require_once 'init.php';

if ($currentUser['id'] == "")
{
        header('Location: index.php');
        exit();
}
$so = 1;
if (!empty($_POST['password']) && !empty($_POST['newpassword']) && !empty($_POST['repassword']))
{
        $user = findUserById($currentUser['id']);
        if (password_verify($_POST['password'], $user['password']))
        {
                $repass = password_hash($_POST['repassword'], PASSWORD_DEFAULT);
                if (password_verify($_POST['newpassword'],$repass))
                {
                        $pass = password_hash($_POST['newpassword'], PASSWORD_DEFAULT);
                        updatepass($pass,$currentUser['id']);
                        header('Location: index.php');
                        exit();
                }
                else
                        $so = 2;
        }
        else
                $so = 3;
}
?>
<?php include 'header.php' ?>
<div class="container">
        <form method="POST">
          <h4></h4>
          <?php if ($so == 3) : ?>
                  <div class="alert alert-danger" role="alert"> Sai Mật Khẩu Cũ </div>
          <?php endif; ?>
          <?php if ($so == 2) : ?>
                  <div class="alert alert-danger" role="alert"> Mật Khẩu Mới Và Xác Nhận Ko Giống Nhau </div>
          <?php endif; ?>
          <div class="form-group">
            <label for="password">Mật khẩu cũ</label>
            <input type="password" class="form-control" id="password" name="password" placeholder="Điền mật khẩu cũ vào đây">
          </div>
          <div class="form-group">
            <label for="newpassword">Mật khẩu mới</label>
            <input type="password" class="form-control" id="newpassword" name="newpassword" placeholder="Điền mật khẩu mới vào đây">
          </div>
          <div class="form-group">
            <label for="repassword">Xác nhận mật khẩu</label>
            <input type="password" class="form-control" id="repassword" name="repassword" placeholder="Điền lại mật khẩu mới">
          </div>
          <button type="submit" class="btn btn-primary">Xác Nhận</button>
        </form>
</div>