<?php
        require_once 'init.php';
        
        if ($currentUser['id'] == "")
        {
                header('Location: index.php');
                exit();
        }
        
        if (!empty($_POST['name'])) 
        {  
                if ($currentUser['id'])
                {
                        updatefullname($_POST['name'],$currentUser['id']);
                        updatephone($_POST['phone'],$currentUser['id']);
                        header('Location: index.php');
                        exit();
                }
        }
?>
<?php include 'header.php' ?>
<div class="container">
        <form method="POST">
          <div class="form-group">
          <h4> Cập Nhật Thông Tin Cá Nhân </h4>
            <label for="name"> <Strong> Họ Tên </Strong> </label>
            <input type="text" class="form-control" id="name" name="name" value="<?php echo $currentUser['fullname'] ?>">
          </div>
          <div class="form-group">
            <label for="phone"> <Strong> Số Điện Thoại </Strong> </label>
            <input type="text" class="form-control" id="phone" name="phone" value="<?php echo $currentUser['phone'] ?>">
          </div>
          <button type="submit" class="btn btn-primary">Xác Nhận</button>
        </form>
</div>