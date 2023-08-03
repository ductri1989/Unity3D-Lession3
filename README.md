# Nhân vật và quái di chuyển bên trong Map
Thiết kế 1 level trong game

### Phạm vi bài giảng
- Tạo project 3D
- Trang trí map
- Setup nhân vật
- Setup quái
    - Tải nhiều loại quái khác nhau
    - Di chuyển quái theo nhiều cách
        - Di chuyển theo 2 điểm cho sẵn
        - Di chuyển theo hình tam giác
        - Di chuyển theo hình vòng tròn
        - Di chuyển theo list Vector3 cho sẵn
        - Di chuyển theo phương trình đường cong theo công thức toán
        - AddForce list Vector3 cho sẵn
    



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




## License
Quyển sở hữu của thầy Dương Đức Trí

`Zalo` : 0379711459
