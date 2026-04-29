Imports MySql.Data.MySqlClient
Module ModuleDB
    Public pengguna As String = ""
    Public ppassword As String = ""
    Public myStrCon As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder()
    Public myConn As MySqlConnection
    Public myCommand As MySqlCommand
    Public myDataReader As MySqlDataReader
    Public myDataAdapter As MySqlDataAdapter
    Public jns As String = String.Empty
    Public tbluser As String = "users"
    Public bts As Integer = 5

    Public Sub CreateConnection()
        myStrCon.UserID = "root"
        myStrCon.Server = "localhost"
        myStrCon.Password = ""
        myStrCon.Database = "parkir"
        myConn = new MySqlConnection(myStrCon.ToString)
    End Sub

    ' Tabel parkir
    'CREATE TABLE `tblparkir` (
    '`id` INT(11) NOT NULL AUTO_INCREMENT,
    '`no_plat` VARCHAR(10) NOT NULL,
    '`waktu_masuk` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    '`waktu_keluar` TIMESTAMP NULL DEFAULT NULL,
    '`jenis` SET('Motor','Mobil','Taksi/Umum','Sepeda','Bus/Truk') NOT NULL DEFAULT 'Motor',
    '`harga` INT(11) NOT NULL,
    '`user` VARCHAR(50) NOT NULL,
    'PRIMARY KEY (`id`)
    ')
    'COLLATE='latin1_swedish_ci'
    'ENGINE=InnoDB;

    ' Tabel langganan
    '    CREATE TABLE `tbllangganan` (
    '	`id` INT(11) NOT NULL AUTO_INCREMENT,
    '	`no_plat` VARCHAR(50) NULL DEFAULT NULL,
    '	`nama` VARCHAR(50) NULL DEFAULT NULL,
    '	`jenis` VARCHAR(50) NULL DEFAULT NULL,
    '	`biaya` INT(11) NULL DEFAULT NULL,
    '	`expired` TIMESTAMP NULL DEFAULT NULL,
    '	PRIMARY KEY (`id`)
    ')
    'ENGINE=InnoDB;

    'Tabel users2
    '    CREATE TABLE `users2` (
    '	`username` VARCHAR(50) NULL DEFAULT NULL,
    '	`password` VARCHAR(50) NULL DEFAULT NULL
    ')
    'ENGINE=InnoDB;

End Module
