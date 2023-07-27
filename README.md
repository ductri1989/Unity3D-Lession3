# Bài 3 : Camera đi theo nhân vật chuyển động
Chủ đề : game nhập vai. Điều khiển 1 nhân vật đánh quái, mở rương và nhặt item. Giết quái và đánh nhiều boss ở các map, nhân vật sẽ thu thập được Gold và vật phẩm. Sử dụng vật phẩm để tăng HP,Attack và Gold

### Phạm vi bài giảng
- Tạo project 3D
- Setup nhân vật
    - Tải nhân vật Maria
    - Giải nén Textures và Materials
    - Tải animation : idle,move,attack,jump
    - Tạo AnimatorController → Setup Blendtree cho hành động idle và moving
    - Xử lý phím di chuyển nhân vật
- Setup camera
    - Camera ở nhiều góc của bản đồ : Lerp và set tọa độ, góc quay
    - Camera gáy :
        - Cam theo nhân vật
        - Cam quay theo góc nhìn của nhân vật
        - Cam ngước lên xuống
    

- Trang trí map

### Resource

| Mixamo | https://www.mixamo.com |
| ------ | ------ |
| Nhân vật | Maria W/Prop J J Ong |
| Idle | Unarmed Idle |
| Move | Unarmed Run Forward |
| Attack | Standing Melee Attack Horizontal |
| Jump | jumping |

### Cấu trúc Folder
+ Assets
    + 📁Các plugin trong game
    + 📁Scenes
        + 📁Model
            + 📁Maria : tất cả resource của nhân vật `Maria` sẽ nằm trong folder này (những anim riêng cũng nằm trong folder này). Cả Materials và Textures của riêng nhân vật Maria cũng nằm trong Folder này
            + 📁Animation : nơi chứa các animation chung của tất cả nhân vật
        + 📁SC_Splash : nơi chứa tài nguyên của Scene 
        + 📁SC_Home : Sau khi vào splash thì vào home
        + 📁SC_LV1 : Sau khi vào splash thì vào home
            + 📄Scene_LV1 : tên scene có tiền tố `Scene_` để dễ search trên `Unity Editor`
            + ⚙️GameManager.cs : script quản lý chung của scene
+ Document
    * tài liệu chung
    * SC_Splash
    * SC_Home

https://drive.google.com/drive/folders/1zUBQ7vXBJ5giGpRlbT0-GvxXzqHOlKwY?usp=drive_link



## License
Quyển sở hữu của thầy Dương Đức Trí

`Zalo` : 0379711459
