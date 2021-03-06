﻿namespace NewerSMBWHookGenerator
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SSIGroupBox = new System.Windows.Forms.GroupBox();
            this.SFIGroupBox = new System.Windows.Forms.GroupBox();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.saveGroupBox = new System.Windows.Forms.GroupBox();
            this.SSIDDX1 = new System.Windows.Forms.TextBox();
            this.SSIDDX2 = new System.Windows.Forms.TextBox();
            this.SSIDDY1 = new System.Windows.Forms.TextBox();
            this.SSIDDY2 = new System.Windows.Forms.TextBox();
            this.SSIXPos = new System.Windows.Forms.TextBox();
            this.SSIYPos = new System.Windows.Forms.TextBox();
            this.isSSI = new System.Windows.Forms.CheckBox();
            this.ActorNum = new System.Windows.Forms.NumericUpDown();
            this.Generate = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cppfilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customspritename = new System.Windows.Forms.TextBox();
            this.ingamespritename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.example = new System.Windows.Forms.Button();
            this.spritefileinfo = new System.Windows.Forms.CheckBox();
            this.spritefileinfotarget = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ActorIName = new System.Windows.Forms.ComboBox();
            this.SpriteName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SpriteNum = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.saveAs = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.copyClipboard = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ActorNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteNum)).BeginInit();
            this.SuspendLayout();
            // 
            // SSIGroupBox
            // 
            this.SSIGroupBox.Location = new System.Drawing.Point(547, 74);
            this.SSIGroupBox.Name = "SSIGroupBox";
            this.SSIGroupBox.Size = new System.Drawing.Size(252, 192);
            this.SSIGroupBox.TabIndex = 37;
            this.SSIGroupBox.TabStop = false;
            this.SSIGroupBox.Text = "Sprite Spawning Settings";
            // 
            // SFIGroupBox
            // 
            this.SFIGroupBox.Location = new System.Drawing.Point(510, 275);
            this.SFIGroupBox.Name = "SFIGroupBox";
            this.SFIGroupBox.Size = new System.Drawing.Size(326, 71);
            this.SFIGroupBox.TabIndex = 38;
            this.SFIGroupBox.TabStop = false;
            this.SFIGroupBox.Text = "Sprite ARC File Loading Settings";
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Location = new System.Drawing.Point(191, 13);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(655, 352);
            this.mainGroupBox.TabIndex = 39;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Sprite Settings";
            // 
            // saveGroupBox
            // 
            this.saveGroupBox.Location = new System.Drawing.Point(30, 294);
            this.saveGroupBox.Name = "saveGroupBox";
            this.saveGroupBox.Size = new System.Drawing.Size(126, 71);
            this.saveGroupBox.TabIndex = 40;
            this.saveGroupBox.TabStop = false;
            this.saveGroupBox.Text = "Saving";
            // 
            // SSIDDX1
            // 
            this.SSIDDX1.Location = new System.Drawing.Point(653, 162);
            this.SSIDDX1.Margin = new System.Windows.Forms.Padding(2);
            this.SSIDDX1.MaxLength = 8;
            this.SSIDDX1.Name = "SSIDDX1";
            this.SSIDDX1.ReadOnly = true;
            this.SSIDDX1.Size = new System.Drawing.Size(134, 20);
            this.SSIDDX1.TabIndex = 26;
            this.SSIDDX1.TextChanged += new System.EventHandler(this.SSIDDX1_TextChanged);
            this.SSIDDX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexBox_KeyPress);
            // 
            // SSIDDX2
            // 
            this.SSIDDX2.Location = new System.Drawing.Point(653, 186);
            this.SSIDDX2.Margin = new System.Windows.Forms.Padding(2);
            this.SSIDDX2.MaxLength = 8;
            this.SSIDDX2.Name = "SSIDDX2";
            this.SSIDDX2.ReadOnly = true;
            this.SSIDDX2.Size = new System.Drawing.Size(134, 20);
            this.SSIDDX2.TabIndex = 28;
            this.SSIDDX2.TextChanged += new System.EventHandler(this.SSIDDX2_TextChanged);
            this.SSIDDX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexBox_KeyPress);
            // 
            // SSIDDY1
            // 
            this.SSIDDY1.Location = new System.Drawing.Point(653, 210);
            this.SSIDDY1.Margin = new System.Windows.Forms.Padding(2);
            this.SSIDDY1.MaxLength = 8;
            this.SSIDDY1.Name = "SSIDDY1";
            this.SSIDDY1.ReadOnly = true;
            this.SSIDDY1.Size = new System.Drawing.Size(134, 20);
            this.SSIDDY1.TabIndex = 30;
            this.SSIDDY1.TextChanged += new System.EventHandler(this.SSIDDY1_TextChanged);
            this.SSIDDY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexBox_KeyPress);
            // 
            // SSIDDY2
            // 
            this.SSIDDY2.Location = new System.Drawing.Point(653, 234);
            this.SSIDDY2.Margin = new System.Windows.Forms.Padding(2);
            this.SSIDDY2.MaxLength = 8;
            this.SSIDDY2.Name = "SSIDDY2";
            this.SSIDDY2.ReadOnly = true;
            this.SSIDDY2.Size = new System.Drawing.Size(134, 20);
            this.SSIDDY2.TabIndex = 32;
            this.SSIDDY2.TextChanged += new System.EventHandler(this.SSIDDY2_TextChanged);
            this.SSIDDY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexBox_KeyPress);
            // 
            // SSIXPos
            // 
            this.SSIXPos.Location = new System.Drawing.Point(653, 114);
            this.SSIXPos.Margin = new System.Windows.Forms.Padding(2);
            this.SSIXPos.MaxLength = 8;
            this.SSIXPos.Name = "SSIXPos";
            this.SSIXPos.ReadOnly = true;
            this.SSIXPos.Size = new System.Drawing.Size(134, 20);
            this.SSIXPos.TabIndex = 22;
            this.SSIXPos.TextChanged += new System.EventHandler(this.SSIXPos_TextChanged);
            this.SSIXPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexBox_KeyPress);
            // 
            // SSIYPos
            // 
            this.SSIYPos.Location = new System.Drawing.Point(653, 138);
            this.SSIYPos.Margin = new System.Windows.Forms.Padding(2);
            this.SSIYPos.MaxLength = 8;
            this.SSIYPos.Name = "SSIYPos";
            this.SSIYPos.ReadOnly = true;
            this.SSIYPos.Size = new System.Drawing.Size(134, 20);
            this.SSIYPos.TabIndex = 24;
            this.SSIYPos.TextChanged += new System.EventHandler(this.SSIYPos_TextChanged);
            this.SSIYPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexBox_KeyPress);
            // 
            // isSSI
            // 
            this.isSSI.AutoSize = true;
            this.isSSI.Location = new System.Drawing.Point(653, 93);
            this.isSSI.Margin = new System.Windows.Forms.Padding(2);
            this.isSSI.Name = "isSSI";
            this.isSSI.Size = new System.Drawing.Size(124, 17);
            this.isSSI.TabIndex = 21;
            this.isSSI.Text = "Sprite Spawning Info";
            this.isSSI.UseVisualStyleBackColor = true;
            this.isSSI.CheckedChanged += new System.EventHandler(this.isSSI_CheckedChanged);
            // 
            // ActorNum
            // 
            this.ActorNum.Location = new System.Drawing.Point(296, 43);
            this.ActorNum.Margin = new System.Windows.Forms.Padding(2);
            this.ActorNum.Maximum = new decimal(new int[] {
            749,
            0,
            0,
            0});
            this.ActorNum.Name = "ActorNum";
            this.ActorNum.Size = new System.Drawing.Size(90, 20);
            this.ActorNum.TabIndex = 0;
            this.ActorNum.ValueChanged += new System.EventHandler(this.ActorNum_ValueChanged);
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(391, 139);
            this.Generate.Margin = new System.Windows.Forms.Padding(2);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(113, 31);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(11, 380);
            this.Output.Margin = new System.Windows.Forms.Padding(2);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(892, 330);
            this.Output.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actor Number:";
            // 
            // cppfilename
            // 
            this.cppfilename.Location = new System.Drawing.Point(391, 69);
            this.cppfilename.Margin = new System.Windows.Forms.Padding(2);
            this.cppfilename.Name = "cppfilename";
            this.cppfilename.Size = new System.Drawing.Size(113, 20);
            this.cppfilename.TabIndex = 4;
            this.cppfilename.TextChanged += new System.EventHandler(this.cppfilename_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "C++ Filename:";
            // 
            // customspritename
            // 
            this.customspritename.Location = new System.Drawing.Point(391, 93);
            this.customspritename.Margin = new System.Windows.Forms.Padding(2);
            this.customspritename.Name = "customspritename";
            this.customspritename.Size = new System.Drawing.Size(113, 20);
            this.customspritename.TabIndex = 6;
            this.customspritename.TextChanged += new System.EventHandler(this.customspritename_TextChanged);
            // 
            // ingamespritename
            // 
            this.ingamespritename.Location = new System.Drawing.Point(391, 116);
            this.ingamespritename.Margin = new System.Windows.Forms.Padding(2);
            this.ingamespritename.Name = "ingamespritename";
            this.ingamespritename.Size = new System.Drawing.Size(113, 20);
            this.ingamespritename.TabIndex = 7;
            this.ingamespritename.TextChanged += new System.EventHandler(this.ingamespritename_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Custom Sprite Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "In-Game Custom Sprite Name:";
            // 
            // example
            // 
            this.example.Location = new System.Drawing.Point(20, 33);
            this.example.Margin = new System.Windows.Forms.Padding(2);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(137, 63);
            this.example.TabIndex = 10;
            this.example.Text = "You don\'t understand how does it work ?\r\nClick here to get an example!";
            this.example.UseVisualStyleBackColor = true;
            this.example.Click += new System.EventHandler(this.example_Click);
            // 
            // spritefileinfo
            // 
            this.spritefileinfo.AutoSize = true;
            this.spritefileinfo.Location = new System.Drawing.Point(690, 294);
            this.spritefileinfo.Margin = new System.Windows.Forms.Padding(2);
            this.spritefileinfo.Name = "spritefileinfo";
            this.spritefileinfo.Size = new System.Drawing.Size(87, 17);
            this.spritefileinfo.TabIndex = 11;
            this.spritefileinfo.Text = "SpriteFileInfo";
            this.spritefileinfo.UseVisualStyleBackColor = true;
            this.spritefileinfo.CheckedChanged += new System.EventHandler(this.spritefileinfo_CheckedChanged);
            // 
            // spritefileinfotarget
            // 
            this.spritefileinfotarget.Location = new System.Drawing.Point(690, 315);
            this.spritefileinfotarget.Margin = new System.Windows.Forms.Padding(2);
            this.spritefileinfotarget.Name = "spritefileinfotarget";
            this.spritefileinfotarget.ReadOnly = true;
            this.spritefileinfotarget.Size = new System.Drawing.Size(134, 20);
            this.spritefileinfotarget.TabIndex = 12;
            this.spritefileinfotarget.TextChanged += new System.EventHandler(this.spritefileinfotarget_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "SpriteFileInfo Target Function:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "NewerSMBW Hook Generator\r\nMade by RedStoneMatt";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActorIName
            // 
            this.ActorIName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActorIName.FormattingEnabled = true;
            this.ActorIName.Items.AddRange(new object[] {
            "BOOT",
            "AUTO_SELECT",
            "SELECT",
            "WORLD_MAP",
            "WORLD__DEMO",
            "STAGE",
            "RESTART_CRSIN",
            "CRSIN",
            "MOVIE",
            "GAMEOVER",
            "GAME_SETUP",
            "MULTI_PLAY_COURSE_SELECT",
            "CURSOR",
            "PLAYER",
            "YOSHI",
            "WM_TEST",
            "WM_TEST",
            "BG_GM",
            "CAMERA",
            "YOSHI_FIRE",
            "SLOW_QUICK_TAG",
            "TORIDE_KOKOOPA_DEMO",
            "BOSS_KAMECK_DEMO",
            "BOSS_KOOPA_DEMO",
            "CASTLE_KOKOOPA_DEMO_ST",
            "CASTLE_KOKOOPA_DEMO_ND",
            "BOSS_KOOPA_JR_DEMO",
            "KOOPA_SHIP_FOR_CASTLE_DEMO",
            "KOOPA_JR_FOR_CASTLE_DEMO",
            "PEACH_FOR_CASTLE_DEMO",
            "KAMECK_FOR_CASTLE_DEMO",
            "LEMMY_FOOTHOLD",
            "LEMMY_FOOTHOLD_MAIN",
            "CASTLE_BOSS_DOOR",
            "CASTLE_BOSS_KEY",
            "AC_BATTLE_GAME",
            "AC_BATTLE_KINOPIO",
            "AC_BATTLE_ITEM",
            "AC_ENDING_MAIN",
            "AC_BLOCK_WIND_TAG",
            "AC_GROUPID",
            "KAWANAGARE",
            "RIVER_PAIPO",
            "RIVER_ITEM",
            "RIVER_COIN",
            "RIVER_STARCOIN",
            "RIVER_LIFT",
            "RIVER_BARREL",
            "RIVER_PUKU",
            "RIVER_PAKKUN",
            "RIVER_MGR",
            "EN_KURIBO",
            "EN_PATA_KURIBO",
            "EN_MAME_KURIBO",
            "EN_NOKONOKO",
            "EN_PATAPATA",
            "EN_MET",
            "EN_TOGEZO",
            "EN_SAKASA_TOGEZO",
            "EN_BLOCK",
            "EN_ITEM",
            "EN_STAR_COIN",
            "EN_STAR_COIN_LINE",
            "EN_STAR_COIN_VOLT",
            "AC_FLAGON",
            "AC_SWICHAND",
            "AC_SWICHOR",
            "AC_RANDSWICH",
            "AC_CHNGESWICH",
            "AC_IFSWICH",
            "AC_RNSWICH",
            "EN_BKBLOCK",
            "EN_HNSWICH",
            "EN_PSWICH",
            "EN_QSWICH",
            "EN_BOSS_KOOPA_SWITCH",
            "EN_BOSS_KOOPA_BIG_SWITCH",
            "EN_BLSWICH",
            "EN_BLPSWICH",
            "EN_BLQSWICH",
            "EN_BUBBLE",
            "EN_DOSUN",
            "EN_BIGDOSUN",
            "EN_JUGEM",
            "EN_JUGEM_COIN",
            "EN_EATJUGEM",
            "EN_JUGEM_BODY",
            "EN_TOGEMET",
            "EN_FIREBAR",
            "EN_TOGETEKKYU",
            "EN_BIG_TOGETEKKYU",
            "EN_UP_DOKAN_PAKKUN",
            "EN_DOWN_DOKAN_PAKKUN",
            "EN_RIGHT_DOKAN_PAKKUN",
            "EN_LEFT_DOKAN_PAKKUN",
            "EN_UP_DOKAN_FPAKKUN",
            "EN_DOWN_DOKAN_FPAKKUN",
            "EN_RIGHT_DOKAN_FPAKKUN",
            "EN_LEFT_DOKAN_FPAKKUN",
            "EN_JIMEN_PAKKUN",
            "EN_JIMEN_BIG_PAKKUN",
            "EN_JIMEN_FPAKKUN",
            "EN_JIMEN_BIG_FPAKKUN",
            "EN_WALK_PAKKUN",
            "ICEBALL",
            "PL_FIREBALL",
            "PAKKUN_FIREBALL",
            "BROS_FIREBALL",
            "BOOMERANG",
            "EN_HELPOS",
            "EN_FIREBROS",
            "EN_BOOMERANGBROS",
            "EN_HAMMERBROS",
            "EN_ICEBROS",
            "EN_LIFT_HAMMERBROS",
            "HAMMER",
            "EN_HIMANBROS",
            "MEGA_HAMMER",
            "BROS_ICEBALL",
            "EN_BOYON",
            "EN_REMOCON_TORIMOCHI",
            "TAG_WIND",
            "TAG_THUNDER",
            "TAG_WATER",
            "EN_AUTOSCR",
            "OBJ_GRASS",
            "EN_ENV",
            "EN_KILLER",
            "EN_SEARCH_KILLER",
            "EN_MAGNUM_KILLER",
            "EN_SEARCH_MAGNUM_KILLER",
            "EN_BASABASA",
            "WAKI_PARABOM",
            "EN_BOMHEI",
            "EN_PARA_BOMHEI",
            "EN_MECHA_KOOPA",
            "EN_MOUSE",
            "EN_GHOST_JUGEM",
            "DOKAN_WAKIDASHI",
            "EN_CRASHER",
            "AC_WAKILIFT",
            "EN_BIRIKYU",
            "EN_LINE_BIRIKYU",
            "EN_BIRIKYU_MAKER",
            "EN_CHOROBON",
            "EN_SANBO",
            "EN_SANBO_PARTS",
            "EN_SANBO_EL",
            "EN_GURUGURU",
            "EN_GESSO",
            "EN_BARAMAKI_GESSO",
            "EN_GOALPOLE",
            "EN_GESSO_CHILD",
            "BARNAR_MGR",
            "EN_SYNCRO_BARNAR",
            "EN_BARNAR",
            "EN_LARGE_BARNAR",
            "EN_PUKUPUKU_PARENT",
            "AC_TEAM_PUKUPUKU",
            "EN_PUKUPUKU",
            "EN_TOGEPUKU",
            "EN_MIDDLE_PUKU",
            "EN_PUKUCOIN",
            "EN_KARON",
            "EN_BIGKARON",
            "EN_KARON_HEAD",
            "EN_REVERSE",
            "EN_WAKI_JUGEM",
            "EN_WIRE_TURN",
            "EN_BIG_WIRE_TURN",
            "EN_NET_NOKONOKO_LR",
            "EN_NET_NOKONOKO_UD",
            "BIGHANA_MGR",
            "HANA_MOUNTAIN",
            "EN_HANACHAN",
            "EN_BIG_HANACHAN",
            "EN_TERESA",
            "EN_BIG_TERESA",
            "EN_CROW",
            "EN_BIGPILE_UNDER",
            "EN_BIGPILE_UPPER",
            "EN_BIGPILE_RIGHT",
            "EN_BIGPILE_LEFT",
            "EN_SUPER_BIGPILE_RIGHT",
            "EN_SUPER_BIGPILE_LEFT",
            "EN_GOKUBUTO_BIGPILE_UNDER",
            "EN_GOKUBUTO_BIGPILE_UPPER",
            "EN_MORTON_BIGPILE",
            "EN_YAJIRUSHI",
            "EN_WANWAN",
            "EN_WANWAN_PILE",
            "EN_JUMPPUKU",
            "EN_IGAPUKU",
            "EN_WAKI_IGAPUKU",
            "EN_FIRESNAKE",
            "EN_BOSS_KAMECK",
            "EN_SLIP_PENGUIN",
            "WAKI_SLIP_PENGUIN",
            "EN_SLIP_PENGUIN",
            "SLIP_PENGUIN_GLASSES",
            "EN_IGA_KURIBO",
            "EN_WATERSTREAM",
            "AWA",
            "DUMMY_DOOR_PARENT",
            "DUMMY_DOOR_CHILD",
            "DUMMY_DOOR",
            "NOBORIBOU_OBAKE",
            "UNTEI_ROPE",
            "REMO_DOOR",
            "REMO_SLIDE_DOOR",
            "BRANCH",
            "BG_CENTER",
            "KAMECK_MAGIC",
            "SINKDOKAN_UP",
            "SINKDOKAN_DOWN",
            "SINKDOKAN_LEFT",
            "SINKDOKAN_RIGHT",
            "FLYDOKAN_UP",
            "FLYDOKAN_DOWN",
            "FLYDOKAN_LEFT",
            "FLYDOKAN_RIGHT",
            "EN_HATENA_BALLOON",
            "EN_ONEWAY_GATE",
            "EN_PATABLOCK",
            "EN_KERONPA",
            "KERONPA_FIRE",
            "AC_NEXTGOTO_BLOCK",
            "EN_BAKUBAKU",
            "EN_DOOR",
            "EN_SWITCHDOOR",
            "EN_OBAKEDOOR",
            "EN_TORIDEDOOR",
            "EN_CASTLEDOOR",
            "EN_KOOPADOOR",
            "AC_REVERSEBLOCK",
            "CHUKAN_POINT",
            "EN_MAX_UE_LEFT",
            "EN_MAX_UE_RIGHT",
            "EN_MAX_UE_LEFT",
            "EN_MAX_UE_RIGHT",
            "EN_ZOOM",
            "EN_BOSS_LARRY",
            "EN_BOSS_WENDY",
            "EN_BOSS_IGGY",
            "EN_BOSS_LEMMY",
            "EN_BOSS_MORTON",
            "EN_BOSS_ROY",
            "EN_BOSS_LUDWIG",
            "EN_BOSS_CASTLE_LARRY",
            "EN_BOSS_CASTLE_ROY",
            "EN_BOSS_CASTLE_WENDY",
            "EN_BOSS_CASTLE_IGGY",
            "CASTLE_LEMMY_BALL",
            "EN_BOSS_CASTLE_LEMMY",
            "EN_BOSS_CASTLE_MORTON",
            "OBJ_LUDWIG",
            "EN_BOSS_CASTLE_LUDWIG",
            "EN_BOSS_KOOPA",
            "EN_BOSS_KOOPA_DEMO_KAMECK",
            "EN_BOSS_KOOPA_DEMO_PEACH",
            "AC_WAKI_KOOPA_FIRE",
            "KOOPA_FIRE",
            "LARRY_FIRE",
            "KOKOOPA_RING",
            "KOKOOPA_BALL",
            "KOKOOPA_THREEWAY_BLITZ",
            "LEMMY_BALL",
            "CASTLE_LEMMY_THROW_BALL",
            "OBJ_IGGY_SLED",
            "OBJ_IGGY_WANWAN",
            "OBJ_MORTON",
            "OBJ_ROY",
            "OBJ_LARRY",
            "OBJ_WENDY",
            "AC_BOSS_KOOPA_SCAFFOLD",
            "AC_BOSS_KOOPA_RUBBLE",
            "AC_BOSS_KOOPA_BG_EFFECT",
            "CASTLE_LUDWIG_BLITZ",
            "CASTLE_LUDWIG_BLITZ_MGR",
            "WAKI_KOKOOPA_FIRE",
            "FALL_FIRE",
            "WAKI_FIRE",
            "FIRE_BLITZ",
            "KOKOOPA_SEARCH_FIRE",
            "EN_UNIZOO",
            "EN_UNIRA",
            "EN_KANIBO",
            "EN_KANITAMA",
            "EN_KOPONE",
            "EN_AKOYA",
            "EN_MIDDLE_KURIBO",
            "EN_LARGE_KURIBO",
            "EN_BEANS_KURIBO",
            "AC_STRONGBOX",
            "EN_REMOCON_CANNON",
            "WAKI_TOGETEKKYU",
            "JR_CLOWN_A",
            "JR_CLOWN_B",
            "JR_CLOWN_C",
            "JR_CLOWN_FOR_PLAYER",
            "FLOOR_JR_A",
            "FLOOR_JR_B",
            "FLOOR_JR_C",
            "FLOOR_JR_C_MGR",
            "BOMB_JR_C",
            "EN_BOSS_KOOPA_JR_A",
            "EN_BOSS_KOOPA_JR_B",
            "EN_BOSS_KOOPA_JR_C",
            "JR_FIRE",
            "JR_FLOOR_FIRE",
            "JR_FLOOR_FIRE_MGR",
            "JR_CLOWN_FOR_JR_C_DEMO",
            "KAMECK_FOR_AIRSHIP_DEMO",
            "PEACH_FOR_AIRSHIP_DEMO",
            "KOOPA_SHIP_FOR_AIRSHIP_DEMO",
            "EN_EATCOIN",
            "AC_WAKI_KILLER",
            "WAKI_KERONPA",
            "AC_WAKI_PUKUPUKU",
            "BELT_NEEDLE",
            "INTERMITTENT",
            "MIST_INTERMITTENT",
            "YOGAN_INTERMITTENT",
            "EN_IBARAMUSHI",
            "WAKI_ANKOH",
            "EN_CHOCHIN_ANKOH",
            "EN_MISTMAN",
            "EN_TESTMAN",
            "EN_CLOUD",
            "AC_ITEM_KEY",
            "AC_YOSHI_EGG",
            "EN_WATERPAIPO",
            "EN_WATERPAKKUN",
            "FOO_BALL",
            "MT_HANACHAN",
            "EN_LR_STOP_UP",
            "EN_LR_STOP_DW",
            "EN_ROT_PAKKUN",
            "EN_POLTER",
            "EN_ICICLE",
            "WALLINSECT_MGR",
            "EN_WALLINSECT",
            "EN_LANDBARREL",
            "EN_IWAO",
            "IWAO_ROCK",
            "KAZAN_MGR",
            "KAZAN_ROCK",
            "EN_CANNON_BULLET",
            "EN_CHOROPU",
            "EN_MANHOLE_CHOROPU",
            "CHOROPOO_SHADOW",
            "MINI_GAME_BALLOON",
            "MINI_GAME_BALLOON_STICK",
            "EN_JELLY_FISH",
            "MINI_GAME_WIRE_MESH",
            "MINI_GAME_GUN_BATTERY_MGR",
            "MINI_GAME_GUN_BATTERY_MGR_OBJ",
            "MINI_GAME_WIRE_MESH_MGR",
            "MINI_GAME_WIRE_MESH_MGR_OBJ",
            "PEACH_CASTLE_SEQUENCE_MGR",
            "PEACH_CASTLE_SEQUENCE_MGR_OBJ",
            "PEACH_CASTLE_BLOCK",
            "MINI_GAME_KINOPIO",
            "AC_KANBAN_ARROW",
            "AC_WATER_BUBBLE",
            "EN_BUBBLE_CONTROL",
            "AC_WAKI_WOODBOX",
            "AC_AUTOSCROOL_SWICH",
            "AC_ROTATION_GHOST_PARENT",
            "EN_ROTATION_GHOST",
            "SHIP_WINDOW",
            "EN_MADOPU",
            "SPANA",
            "EN_GABON",
            "GABON_ROCK",
            "MANHOLE",
            "BGM_INTERLOCKING_DUMMY_BLOCK",
            "BGM_INTERLOCKING_DUMMY_BLOCK_MGR",
            "EN_KING_KILLER",
            "EN_WATER_BUBBLE_BULLET",
            "EN_FRUIT",
            "OBJ_SPARKS",
            "OBJ_SNOW",
            "TAG_SCROLL",
            "AC_BLOCK_GROUP",
            "AC_BLOCK_ONEUP",
            "AC_BLOCK_COIN",
            "AC_WAKI_SEARCH_MAGKILLER",
            "EN_TOBIPUKU",
            "AC_WAKI_TOBIPUKU",
            "NEEDLE_FOR_KOOPA_JR_B",
            "TOP_BG_FOR_CASTLE_LUDWIG",
            "MIDDLE_BG_FOR_CASTLE_LUDWIG",
            "BOTTOM_BG_FOR_CASTLE_LUDWIG",
            "MD_ACTOR",
            "MD_CAMERA",
            "EN_CLOUDLT",
            "UNIT_RAIL",
            "UNIT_CHIKUWA",
            "OBJ_SEAWEED",
            "TAG_ENVSOUND",
            "EN_COIN",
            "EN_COIN_JUGEM",
            "EN_COIN_JUMP",
            "EN_COIN_FLOOR",
            "EN_COIN_VOLT",
            "EN_COIN_WIND",
            "EN_BLUE_COIN",
            "EN_COIN_WATER",
            "EN_REDCOIN",
            "EN_GREENCOIN",
            "ICE_ACTOR",
            "AC_LIGHT_BLOCK",
            "AC_PROP_BLOCK",
            "ENEMY_ICE",
            "PLAYER_ICE",
            "SLIDE_BLOCK",
            "POW_BLOCK",
            "BLOCK_TARU",
            "OBJ_CENTER",
            "OBJ_CENTER",
            "EN_LIFT_ROTATION_FULL",
            "LIFT_ROTATION_FULL_CHIKA",
            "LIFT_ROTATION_FULL_KINOKO",
            "LIFT_ROTATION_FULL_COLOR",
            "CAGE_BLOCK",
            "LIFT_ZEN_HAMMER",
            "LIFT_ZEN_SUISYA",
            "LIFT_ZEN_KAITEN_KANAAMI",
            "MOUSE_HOLE",
            "KATAMUKIYUKA",
            "LIFT_TORIDE_ROLL",
            "AC_LIFT_RIDE_HMOVE",
            "AC_LIFT_OBJBG_VMOVE",
            "AC_LIFT_OBJBG_HMOVE",
            "AC_LIFT_OBJBG_HMOVE_BIG",
            "EN_OBJ_POL",
            "EN_OBJ_POL_TORIDE",
            "EN_OBJ_POL_NEEDLE_L",
            "EN_OBJ_POL_NEEDLE_R",
            "EN_OBJ_POL_NEEDLE_LR",
            "EN_OBJ_POL_NEEDLE_U",
            "EN_OBJ_POL_NEEDLE_D",
            "EN_OBJ_POL_NEEDLE_UD",
            "LIFT_ZEN_TOGE",
            "LIFT_ZEN_SHIRO_YOGAN",
            "LIFT_ZEN_KAIHEI",
            "LIFT_DOKAN",
            "EN_PAIR_OBJ_PARENT",
            "EN_PAIR_OBJ_CHILD",
            "LIFT_ZEN_SHIRO",
            "EN_PAIR_OBJ_CHILD_TORIDE",
            "WAKI_ICE_ASHIBA",
            "WAKI_ICE_ASHIBA_WATER",
            "ICE_ASHIBA",
            "ICE_ASHIBA_WATER",
            "ICE_ASHIBA_RAIL",
            "AC_LIFT_RIDE_VMOVE",
            "AC_LIFT_SEESAW",
            "AC_LIFT_FALL",
            "AC_LIFT_REMOCON_SEESAW",
            "EN_LIFT_WHEEL",
            "AC_LIFT_BALANCE",
            "AC_LIFT_REMOCON_BALANCE_CLINCH",
            "AC_LIFT_REMOCON_BALANCE",
            "AC_LIFT_REMOCON_XLINE",
            "EN_LIFT_REMOCON_TRPLN",
            "EN_TRPLN_WALL",
            "EN_CHIKUWA_BLOCK",
            "EN_CLIFF_CHIKUWA_BLOCK",
            "EN_KILLER_HOUDAI",
            "EN_MAGNUM_KILLER_HOUDAI",
            "AC_WAKILIFT_STEP",
            "AC_LINE_LIFT",
            "LINE_SPIN_LIFT",
            "PALM_TREE",
            "NICE_BOAT",
            "LINE_KINOKO_BLOCK",
            "LADDER",
            "TARZAN_TSUTA",
            "TARZAN_IVY",
            "EN_LIFT_ROTATION_HALF",
            "LIFT_HURIKO_CENTER",
            "LIFT_HURIKO",
            "AC_LIFT_RIDEMOVE",
            "EN_LIFT_BURANKO",
            "AC_LIFT_WATERWHEEL",
            "EN_RAIL_POLYGON",
            "EN_RAIL_POLY_ICE",
            "EN_RAIL_POLY_PARENT",
            "EN_RAIL_POLY_CHILD",
            "FREEFALL",
            "EN_GURA_ROCK",
            "EN_GURA_YUKA",
            "EN_KAITEN_HOUDAI",
            "EN_REDRING",
            "EN_BARREL",
            "EN_JUMPDAI",
            "EN_BIG_HNSWICH",
            "EN_BIGBLOCK",
            "EN_SNAKEBLOCK",
            "EN_MARUTA",
            "OBJ_KAMECK",
            "AC_LIFT_SPINROTATION",
            "AC_LIFT_SPINROTATION_SYNC",
            "EN_RULETBLOCK",
            "AC_LIFT_SCALES",
            "AC_LIFT_SCALES_STEP",
            "EN_TARZANROPE",
            "AC_LIFT_BOSS_REMOCON_SEESAW",
            "AC_CHENGE_BLOCK",
            "EN_FIXATION_ICICLE",
            "EN_OBJ_HATENA_BLOCK",
            "EN_OBJ_HATENAB_BLOCK",
            "EN_OBJ_RENGA_BLOCK",
            "EN_OBJ_CLEAR_BLOCK",
            "AC_OBJ_CLEAR_BLOCK",
            "EN_HATENA_BLOCK_LINE",
            "EN_RENGA_BLOCK_LINE",
            "EN_BLOCK_HATENA_WATER",
            "EN_BLOCK_SOROBAN",
            "EN_BLOCK_STAFFROLL",
            "ELASTIC_KINOKO_PARENT",
            "ELASTIC_KINOKO",
            "EN_WHITE_BLOCK",
            "MANTA_MGR",
            "MANTA_MGR",
            "MANTA",
            "AC_LIFT_SLIDE_KINOKO",
            "EN_ROTATION_BLOCK",
            "EN_COIN_ANGLE",
            "ROT_DOKAN",
            "EN_BLOCK_HATENA_ANGLE",
            "EN_BLOCK_RENGA_ANGLE",
            "AC_WIRE_CIRCLE",
            "AC_WIRE_REMOCON",
            "AC_LIFT_ICE_SPRING",
            "ICELUMP",
            "ICECUBE",
            "EN_WOODBOX",
            "EN_PATAMET",
            "EN_BIG_PATAMET",
            "NUT",
            "EN_BIG_MET",
            "EN_GAKE_NOKO",
            "AC_DOKAN_CANNON",
            "AC_SHIP_CANNON",
            "AC_ROT_CANNON",
            "AC_ROT_DOKAN_CANNON",
            "ROT_BARNAR",
            "CIRCLE_RIGHT",
            "BLOCK_LIGHT",
            "HAND_RIGHT",
            "EN_BIG_ICICLE",
            "AC_WATER_BUBBLE_PARENT",
            "AC_WATER_BUBBLE_CANNON",
            "EN_KILLER_HOUDAI_SLIDE",
            "EN_BLACK_PAKKUN",
            "TORCHILIGHT",
            "EN_BLOCK_CLOUD",
            "AC_WIRE_MOVE",
            "OBJ_FRUITTREE",
            "EN_BOUNCE_BALL",
            "EN_BLOCK_HATENA_PLAYER",
            "EN_BLOCK_RENGA_PLAYER",
            "AC_FREEZER",
            "AC_WIRE_FOOTHOLD",
            "EN_ITEM_IVY",
            "TARZAN_ROPE",
            "CANNON_PIPE",
            "KINOKO_LIFT_PARENT",
            "KINOKO_LIFT",
            "OBJ_SPIN_PARENT",
            "OBJ_SPIN_CHILD",
            "OBJ_SPIN_ASHIBA",
            "SPIN_WIRE",
            "WARP_CANNON",
            "OBJ_KINOKO",
            "ZOOM_PIPE",
            "ZOOM_PIPE_DOWN",
            "OBJ_PIPE_UP",
            "OBJ_PIPE_UP_NG",
            "OBJ_PIPE_DOWN",
            "OBJ_PIPE_RIGHT",
            "OBJ_PIPE_LEFT",
            "LIFT_DOWN_ON",
            "OBJ_MOVE_ON_GHOST",
            "LIFT_DOWN_ON_NORMAL",
            "LIFT_RIDE_OFF",
            "LINE_TRAIN",
            "REMO_LINE_LIFT",
            "WATER_LIFT",
            "AC_NICE_COIN",
            "AC_NICE_COIN_REGULAR",
            "EN_BLOCK_HELP",
            "FAR_BG",
            "AC_BG_WATER",
            "AC_BG_LAVA",
            "AC_BG_POISON",
            "AC_BG_SAND",
            "AC_BG_CLOUD",
            "AC_BG_MOYA",
            "AC_WATERALL_RAIL",
            "EN_BLUR",
            "MASK",
            "DTEST",
            "AC_WATER_MOVE",
            "AC_WATER_MOVE_REGULAR",
            "AC_WATER_XINFINITE_MOVE",
            "AC_FLOOR_GYRATION",
            "AC_FLOOR_HOLE_DOKAN",
            "AC_FLOOR_DOKAN_EIGHT",
            "AC_GEAR_GYRATION",
            "AC_SHIP_GEAR",
            "AC_BIGSHELL",
            "EN_BOSS_KOOPA_DEMO_CAGE",
            "AC_STAND",
            "AC_HOUSE_LIGHT",
            "AC_LIGHT_WATER",
            "AC_COPYRIGHT",
            "WII_STRAP",
            "WM_CS_SEQ_MNG",
            "WORLD_CAMERA",
            "WM_MAP",
            "WM_IBARA",
            "WM_ANTLION_MNG",
            "WM_CASTLE",
            "WM_TOWER",
            "WM_PEACH_CASTLE",
            "WM_KILLER",
            "WM_KILLERBULLET",
            "WM_SINKSHIP",
            "WM_SWITCH",
            "WM_START",
            "WM_KINOKO_BASE",
            "WM_KINOKO_RED",
            "WM_KINOKO_UP",
            "WM_KINOKO_STAR",
            "WM_COURSE",
            "WM_STOP",
            "WM_TORIDE",
            "WM_GHOST",
            "WM_DOKAN",
            "WM_CANNON",
            "WM_KOOPASHIP",
            "WM_BOSS_BASE",
            "WM_BOSS_LARRY",
            "WM_BOSS_ROY",
            "WM_BOSS_WENDY",
            "WM_BOSS_IGGY",
            "WM_BOSS_LEMMY",
            "WM_BOSS_MORTON",
            "WM_BOSS_LUDWIG",
            "WM_BOSS_KAMECK",
            "WM_ANTLION",
            "WM_KURIBO",
            "WM_PUKU",
            "WM_PAKKUN",
            "WM_BROS",
            "WM_JUGEM",
            "WM_PLAYER",
            "WM_SUBPLAYER",
            "WM_NOTE",
            "WM_TREASURESHIP",
            "WM_DIRECTOR",
            "WM_GRID",
            "WM_ISLAND",
            "WM_ITEM",
            "WM_CS_W_PALM",
            "WM_SURRENDER",
            "WM_KOOPA_CASTLE",
            "WM_ANCHOR",
            "WM_PAKKUNHEAD",
            "WM_CLOUD",
            "WM_SMALLCLOUD",
            "WM_KOOPAJR",
            "WM_PEACH",
            "WM_BOARD",
            "WM_BUBBLE",
            "WM_KINOBALLOON",
            "WM_SANDPILLAR",
            "WM_YOGANPILLAR",
            "WM_KINOPIO",
            "WM_DANCE_PAKKUN",
            "WM_DOKANROUTE",
            "WM_HANACHAN",
            "WM_TOGEZO",
            "WM_MANTA",
            "WM_TERESA",
            "WORLD_SELECT",
            "WORLD_SELECT_GUIDE",
            "COLLECTION_COIN_BASE",
            "COLLECTION_COIN",
            "COURSE_SELECT_MENU",
            "NUMBER_OF_PEOPLE_CHANGE",
            "STOCK_ITEM",
            "STOCK_ITEM_SHADOW",
            "EASY_PAIRING",
            "WM_D_PLAYER",
            "EVENT_OPENING_TITLE",
            "SELECT_PLAYER",
            "MULTI_COURSE_SELECT",
            "TIME_UP",
            "COURSE_TIME_UP",
            "YES_NO_WINDOW",
            "COURSE_SELECT_MANAGER",
            "FUKIDASHI_MANAGER",
            "SMALL_SCORE_MANAGER",
            "GAMEDISPLAY",
            "OTASUKE_INFO",
            "PAUSEWINDOW",
            "RESULT",
            "POINT_RESULT_MULTI",
            "POINT_RESULT_DATE_FILE",
            "POINT_RESULT_DATE_FILE_FREE",
            "GOAL_MANAGER",
            "COURSE_CLEAR",
            "OTEHON_CLEAR",
            "INFO_WINDOW",
            "SELECT_CURSOR",
            "WARNING_MANAGER",
            "SEQUENCE_BG",
            "GAME_OVER",
            "MODE_SELECT",
            "DATE_FILE",
            "FILE_SELECT",
            "CONTINUE",
            "MINI_GAME_CANNON",
            "MINI_GAME_WIRE",
            "MODEL_PLAY_MANAGER",
            "MODEL_PLAY_BASE",
            "MODEL_PLAY_DATE",
            "MODEL_PLAY_ARROW",
            "MODEL_PLAY_GUIDE",
            "MESSAGE_WINDOW",
            "CHARACTER_CHANGE_SELECT_BASE",
            "CHARACTER_CHANGE_SELECT_CONTENTS",
            "CHARACTER_CHANGE_SELECT_ARROW",
            "CHARACTER_CHANGE_INDICATOR",
            "MULTI_COURSE_SELECT_CONTENTS",
            "COLLECTION_COIN_DATE",
            "CONTROLLER_INFORMATION",
            "DRAW_GAME",
            "STAFF_CREDIT_SCORE",
            "THE_END",
            "DEMO_MESSAGE",
            "LETTER_WINDOW",
            "DUMMY_ACTOR",
            "LASTACTOR_STAGE",
            "LASTACTOR"});
            this.ActorIName.Location = new System.Drawing.Point(391, 43);
            this.ActorIName.Name = "ActorIName";
            this.ActorIName.Size = new System.Drawing.Size(113, 21);
            this.ActorIName.TabIndex = 15;
            this.ActorIName.SelectedIndexChanged += new System.EventHandler(this.ActorIName_SelectedIndexChanged);
            // 
            // SpriteName
            // 
            this.SpriteName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpriteName.FormattingEnabled = true;
            this.SpriteName.Items.AddRange(new object[] {
            "BOOT",
            "AUTO_SELECT",
            "SELECT",
            "WORLD_MAP",
            "WORLD_9_DEMO",
            "STAGE",
            "RESTART_CRSIN",
            "CRSIN",
            "MOVIE",
            "GAMEOVER",
            "GAME_SETUP",
            "MULTI_PLAY_COURSE_SELECT",
            "CURSOR",
            "PLAYER",
            "YOSHI",
            "WM_TEST",
            "WM_TEST2",
            "BG_GM",
            "CAMERA",
            "YOSHI_FIRE",
            "Boss - Topman",
            "Boss Controller - Tower Boss",
            "Kamek",
            "Bowser Boss Battle Related",
            "Cutscene Controller - Castle Boss",
            "Cutscene Controller - Bowser Jr and Peach at Castle",
            "Cutscene Controller - Bowser Jr and Peach at Airship",
            "KOOPA_SHIP_FOR_CASTLE_DEMO",
            "KOOPA_JR_FOR_CASTLE_DEMO",
            "PEACH_FOR_CASTLE_DEMO",
            "KAMECK_FOR_CASTLE_DEMO",
            "LEMMY_FOOTHOLD",
            "LEMMY_FOOTHOLD_MAIN",
            "Castle Boss Door",
            "Castle Boss Key",
            "Ambush Level Controller",
            "AC_BATTLE_KINOPIO",
            "AC_BATTLE_ITEM: Ambush Mushroom Reward",
            "Credits Controller",
            "Wind-Riding Coins",
            "Movement Controller - \"Ac_GroupID\"",
            "Electric Line",
            "RIVER_PAIPO",
            "RIVER_ITEM",
            "RIVER_COIN",
            "RIVER_STARCOIN",
            "RIVER_LIFT",
            "RIVER_BARREL",
            "RIVER_PUKU",
            "RIVER_PAKKUN",
            "Line God",
            "Goomba",
            "Paragoomba",
            "Unused Goomba, dies upon contact, usable",
            "Koopa Troopa",
            "Koopa Paratroopa",
            "Buzzy Beetle",
            "Spiny",
            "Upside-Down Spiny",
            "EN_BLOCK",
            "EN_ITEM, Actor handling items",
            "Star Coin",
            "Line Controlled Star Coin",
            "Bolt Controlled Star Coin",
            "Event Controller - Zone Enter",
            "Event Controller - \"And\"",
            "Event Controller - \"Or\"",
            "Event Controller - \"Random\"",
            "Event Controller - Chainer (If X, do Y)",
            "Event Controller - \"If\"",
            "Event Controller - Multi-Chainer (If X, do Y THROUGH Z)",
            "EN_BKBLOCK - Breaking Block",
            "Event Controller - \"?\"",
            "Event Controller - \"P\"",
            "Event Controller - \"!\"",
            "Final Boss Controller - First Switch",
            "Final Boss Controller - Second Switch",
            "Event Controller - Brick Block \"?\"",
            "Event Controller - Brick Block \"P\"",
            "Event Controller - Brick Block \"!\"",
            "Podoboo",
            "Thwomp",
            "Big Thwomp",
            "Lakitu",
            "EN_JUGEM_COIN - Coin Lakitu",
            "EN_EATJUGEM",
            "EN_JUGEM_BODY",
            "Spike Top",
            "Spinning Firebar",
            "Spike Ball",
            "Giant Spike Ball",
            "Pipe - Piranha Plant - Up Facing",
            "Pipe - Piranha Plant - Down Facing",
            "Pipe - Piranha Plant - Right Facing",
            "Pipe - Piranha Plant - Left Facing",
            "Pipe - Venus Fire Trap - Facing Up",
            "Pipe - Venus Fire Trap - Facing Down",
            "Pipe - Venus Fire Trap - Facing Right",
            "Pipe - Venus Fire Trap - Facing Left",
            "Grounded Piranha Plant",
            "Giant Grounded Piranha Plant",
            "Grounded Venus Fire Trap",
            "Giant Grounded Venus Fire Trap",
            "Extending Piranha Plant",
            "ICEBALL - Player Iceball",
            "PL_FIREBALL - Player Fireball",
            "PAKKUN_FIREBALL - Venus Fire Traps Fireball",
            "BROS_FIREBALL - Fireball thrown by Fire Bros.",
            "BOOMERANG - Boomerang used by Boomerang Bros.",
            "Event Looper",
            "Fire Brother",
            "Boomerang Brother",
            "Hammer Brother",
            "Ice Brother",
            "Hammer Brother",
            "HAMMER - Hammer thrown by Hammer Bros.",
            "Big Sledge Brother",
            "MEGA_HAMMER - Hammer thrown by Sledge Bros.",
            "BROS_ICEBALL - Iceballs thrown by Ice Bros.",
            "Actor Spawner",
            "Timed Actor Spawner",
            "Effect - Wind Physics and Sound",
            "Special Level Events",
            "Unused Sprite - \"Tag_Water\"",
            "Auto-Scrolling Controller - Requires Rails",
            "OBJ_GRASS - The grass model that replaces the tiles in Pa1_nohara",
            "Effect - Sunlight",
            "EN_KILLER - Bullet Bill",
            "EN_SEARCH_KILLER - Heat seeking Bullet Bill",
            "EN_MAGNUM_KILLER - Banzai Bill",
            "EN_SEARCH_MAGNUM_KILLER - Heat seeking Banzai Bill",
            "Swooper",
            "Para-bomb Spawn Area",
            "Bob-omb",
            "Para-bomb",
            "Mecha-Koopas",
            "Little Mouser",
            "Boss - Thwompadomp",
            "Pipe Enemy Generator",
            "Broozer",
            "Vertical Platform Generator",
            "Amp",
            "EN_LINE_BIRIKYU - Line Controlled Amp",
            "Unused Sprite - \"En_Birikyu_Maker\"",
            "Line Controlled Fuzzy",
            "Pokey",
            "EN_SANBO_PARTS - Unused",
            "EN_SANBO_EL - Pokey parts",
            "Rotating Spike Ball on Chain [6x6",
            "Blooper",
            "Blooper with Babies",
            "Flagpole",
            "EN_GESSO_CHILD - Blooper Baby",
            "Synchronized Flame Jet Controller",
            "Synchronized Flame Jet ",
            "Continuous Flame Cannon",
            "Pulsating Flame Cannon",
            "Unused Sprite - \"En_Pukupuku_Parent\"",
            "School of Cheep-Cheeps",
            "Small Cheep Cheep",
            "Spiny Cheep-Cheep",
            "Giant Cheep-Cheep",
            "Unused Sprite - \"En_Pukucoin\"",
            "Dry Bones",
            "Giant Dry Bones",
            "EN_KARON_HEAD - Dry Bone Head",
            "Sprite Crashes Game - \"En_Reverse\"",
            "Lakitu Spawner",
            "Chain Link Flip Panel [XxY]",
            "Long Chain Link Flip Panel [XxY]",
            "Chain Link Koopa - Horizontal",
            "Chain Link Koopa - Vertical",
            "Unused Sprite - \"Bighana_Mgr\"",
            "Ending Manager",
            "Wiggler",
            "Giant Wiggler",
            "Boo",
            "Big Boo [6x6",
            "Purple Crow",
            "Spiked 3D Stake - Down",
            "Spiked 3D Stake - Up",
            "Spiked 3D Stake - Right",
            "Spiked 3D Stake - Left",
            "Gigantic Spike Pillar - Right",
            "Gigantic Spike Pillar - Left",
            "Gigantic Spike Pillars - Down",
            "Gigantic Spike Pillars - Up",
            "Medium Spike Pillar - Down",
            "Loose Arrow",
            "EN_WANWAN - Chomp",
            "Chain Chomp [XxY]",
            "Surfaced Leaping Cheep Cheep - \"En_JumpPuku\"",
            "Porcu-Puffer",
            "Porcu-Puffer Spawner",
            "Fire Snake ",
            "Boss Controller - Kamek",
            "Magic Platform",
            "Cooligan Generator",
            "Cooligan",
            "SLIP_PENGUIN2_GLASSES - Cooligan\'s Glasses",
            "Chestnut Goomba",
            "Pipe - Bubbles",
            "AWA - Bubble",
            "Fire Laser",
            "Shy Guy",
            "Unused Sprite - \"Dummy_Door\"",
            "Purple Striped Climbable Pole",
            "Horizontal Rope",
            "D-Pad Door - \"Remo_Door\"",
            "Falling Chestnut",
            "Captain Bowser",
            "View Related - Background Centering",
            "KAMECK_MAGIC - Kamek\'s heatseeking magic",
            "SINKDOKAN_UP",
            "SINKDOKAN_DOWN",
            "SINKDOKAN_LEFT",
            "SINKDOKAN_RIGHT",
            "FLYDOKAN_UP",
            "FLYDOKAN_DOWN",
            "FLYDOKAN_LEFT",
            "FLYDOKAN_RIGHT",
            "Unused Sprite - \"En_Hatena_Balloon\"",
            "\"One-Way Gate\"",
            "Flying Question Block",
            "Fire Chomp",
            "KERONPA_FIRE - Fireball spat by the Fire Chomp",
            "Special Exit Controller - [y2=n11+1]",
            "Cheep-Chomp",
            "D-Pad Door",
            "Unused Sprite - \"En_SwitchDoor\"",
            "Ghost House Door",
            "Tower Boss Door",
            "Castle Boss Door",
            "Bowser Boss Door",
            "Collision Switcher - Mini-Mario Only",
            "Midway Point Flag",
            "Border of Level Related - Left Side",
            "Border of Level Related - Right Side",
            "Border of Level Related - Left Side (2)",
            "Border of Level Related - Right Side (2)",
            "View Related - Zoom",
            "Larry Koopa",
            "Wendy Koopa",
            "Iggy Koopa",
            "Lemmy Koopa",
            "Morton Koopa",
            "Roy Koopa",
            "Ludwig von Koopa",
            "Boss Controller - Larry Koopa",
            "Boss Controller - Roy Koopa",
            "Boss Controller - Wendy Koopa",
            "Boss Controller - Iggy Koopa",
            "CASTLE_LEMMY_BALL - One of Lemmy\'s Balls.",
            "Boss Controller - Lemmy Koopa",
            "Boss Controller - Morton Koopa",
            "OBJ_LUDWIG - Ludwig von Koopa",
            "Boss Controller - Ludwig von Koopa",
            "Bowser",
            "Fake Peach in Cage",
            "Peach in Cage",
            "Bowser Fireball Spawn Area",
            "KOOPA_FIRE - Bowser\'s Fireballs",
            "LARRY_FIRE - Larry\'s Fireballs",
            "\"Gold Ring\"",
            "KOKOOPA_BALL - One of Lemmy\'s Balls.",
            "KOKOOPA_THREEWAY_BLITZ - Ludwig\'s Castle Battle ",
            "LEMMY_BALL - One of Lemmy\'s Balls.",
            "CASTLE_LEMMY_THROW_BALL - One of Lemmy\'s Balls.",
            "OBJ_IGGY_SLED - Iggy\'s Chain Chomp platform",
            "OBJ_IGGY_WANWAN - Iggy\'s Chain Chomp",
            "OBJ_MORTON - Morton Koopa",
            "OBJ_ROY - Roy Koopa",
            "OBJ_LARRY - Larry Koopa",
            "OBJ_WENDY - Wendy Koopa",
            "Final Battle Bowser Bridge",
            "Sprite Crashes Game - \"Ac_Boss_Koopa_Rubble\"",
            "Final Castle Background Effects",
            "CASTLE_LUDWIG_BLITZ - Ludwig Battle Related",
            "CASTLE_LUDWIG_BLITZ_MGR - Ludwig Battle Controler",
            "Magic Fireball Spawn Area",
            "FALL_FIRE - Some effect related to the fireballs",
            "Fireball Spawn Area",
            "FIRE_BLITZ - Fireball",
            "KOKOOPA_SEARCH_FIRE - Heatsiking Battle Ludwig Magic",
            "Urchin",
            "Mega Urchin",
            "Huckit Crab",
            "EN_KANITAMA - Huckit Rock",
            "Fishbones",
            "Clampy",
            "Giant Goomba",
            "Mega Goomba",
            "Micro Goomba",
            "Toad House - Chest",
            "Toad House - Cannon",
            "Rolling Spike Ball Generator",
            "JR_CLOWN_A - Koopa Clown Copter Battle 1",
            "JR_CLOWN_B - Koopa Clown Copter Battle 2",
            "JR_CLOWN_C - Koopa Clown Copter Battle 3",
            "Player Clown Car",
            "FLOOR_JR_A - Floor in Bowser Junior\'s first battle",
            "FLOOR_JR_B - Floor in Bowser Junior\'s second battle",
            "FLOOR_JR_C - Floor in Bowser Junior\'s third battle",
            "FLOOR_JR_C_MGR - Third Bowser Junior battle floor controller",
            "BOMB_JR_C - Gigantic third Bowser Junior Battle Bomb",
            "Boss Controller - Bowser Jr. 1st Battle",
            "Boss Controller - Bowser Jr. 2nd Battle",
            "Boss Controller - Bowser Jr. 3rd Battle",
            "JR_FIRE - Bowser Junior\'s fire",
            "JR_FLOOR_FIRE - Fire that burns on the floor during Bowser Junior battles",
            "JR_FLOOR_FIRE_MGR - Fire that burns on the floor during Bowser Junior battles con" +
                "troller",
            "JR_CLOWN_FOR_JR_C_DEMO - Pre-third Bowser Jr. battle cutscene\'s broken jr. copter" +
                ".",
            "KAMECK_FOR_AIRSHIP_DEMO",
            "PEACH_FOR_AIRSHIP_DEMO - Cutscenes",
            "KOOPA_SHIP_FOR_AIRSHIP_DEMO",
            "EN_EATCOIN - Edible Coin",
            "Bullet Bill Spawn Area",
            "Fire Chomp Spawn Area",
            "Unused Sprite - \"Ac_Waki_Pukupuku\"",
            "Unused Platform - \"Belt_Needle\"",
            "Sand Pillar",
            "Event Block",
            "Lava Geyser",
            "Bramball",
            "Bulber (Glowing Fish) Spawn Area",
            "Bulber (Glowing Fish)",
            "Foo (Cloud Blower)",
            "Boss Controller - Larry Koopa Unused",
            "Clouds",
            "Doomship Key",
            "AC_YOSHI_EGG - Yoshi Egg?",
            "EN_WATERPAIPO - Spiny egg, floats on water",
            "River Piranha Plant",
            "FOO_BALL - River Piranha Plant\'s ball",
            "MT_HANACHAN - Wiggler mountain, no code.",
            "x",
            "x",
            "EN_ROT_PAKKUN - doesn\'t spawn anything",
            "Poltergeist Item",
            "Falling Icicle",
            "Boss - Fuzzy Bear",
            "Mr Sun",
            "Old Barrel",
            "Boss - Ramboo",
            "IWAO_ROCK - No code",
            "Volcano Rock Spawn Area",
            "KAZAN_ROCK - Volcano Rock",
            "EN_CANNON_BULLET - Cannon Ball",
            "Monty Mole",
            "Rocky Wrenches",
            "CHOROPOO_SHADOW - Monty Mole digging spot",
            "Toad House - Lives Balloon Unused",
            "Toad House - Lives Balloon",
            "Jellybeam",
            "Toad House - Minigame Flip Panels",
            "Toad House Controller - Cannon Minigame",
            "MINI_GAME_GUN_BATTERY_MGR_OBJ - Cannon minigame related.",
            "Toad House Controller - Item Panel Minigame",
            "MINI_GAME_WIRE_MESH_MGR_OBJ - Item Panel minigame related",
            "Peach\'s Castle -\"Peach_Castle_Sequence_Mgr\"",
            "PEACH_CASTLE_SEQUENCE_MGR_OBJ - Hint Movie related",
            "Peach\'s Castle - Hint Movies Block",
            "Toad House - Toad",
            "Arrow Signboard",
            "Effect - Bubble Generator",
            "Effect - \"En_Bubble_Control\"",
            "Box",
            "Beta Arrow Block",
            "Boo Circle",
            "EN_ROTATION_GHOST - Boo Circle Boo",
            "Boss - Podouble",
            "EN_MADOPU - No code, deletes itself.",
            "Flying Wrench",
            "Gabon",
            "GABON_ROCK - Gabon\'s Rock",
            "MANHOLE - Rocky Wrench\' Manhole",
            "BGM_INTERLOCKING_DUMMY_BLOCK - Dancing Coin",
            "Dancing Coin Controller",
            "King Bill",
            "EN_WATER_BUBBLE_BULLET - Water Bullet Bill",
            "Yoshi Fruit/Cookie",
            "Effect - Rising Lava Particle",
            "Effect - Snow / Wind Visuals",
            "Effect - Airship Rocking",
            "Giga Goomba",
            "Invisible 1-Up - Mini-Mario Only",
            "Spin-Jump Coin (Unused)",
            "Homing Banzai Bill Generator",
            "EN_TOBIPUKU - Cheep Cheep School",
            "Cheep Cheep Spawner",
            "NEEDLE_FOR_KOOPA_JR_B - Lasers in the second Bowser Jr. fight.",
            "TOP_BG_FOR_CASTLE_LUDWIG",
            "MIDDLE_BG_FOR_CASTLE_LUDWIG",
            "BOTTOM_BG_FOR_CASTLE_LUDWIG",
            "MD_ACTOR",
            "MD_CAMERA",
            "Cloud Area",
            "UNIT_RAIL - Line guide",
            "UNIT_CHIKUWA - Related to the donut lifts.",
            "Seaweed Plant",
            "Effect - Environmental Sound Effects",
            "Coin",
            "EN_COIN_JUGEM - Lakitu\'s Coins",
            "EN_COIN_JUMP - Some type of a jumping coin",
            "Rolling Hill Controlled Coin",
            "Bolt Controlled Coin",
            "EN_COIN_WIND - Wind Controlled Coin",
            "Blue P-Switch Coin",
            "Unused Sprite - \"En_Coin_Water\"",
            "Red Coin",
            "Ambush - Toad Balloons",
            "ICE_ACTOR - Model for the frozen enemy/player",
            "Lighting - Glow Block",
            "Propeller Block",
            "ENEMY_ICE - Frozen enemy",
            "PLAYER_ICE - Frozen Player",
            "Grabbable Ice Block",
            "POW Block",
            "Barrel",
            "Rotation Controller - Swaying",
            "Rotation Controller - Spinning",
            "Unused Platform - \"En_Lift_Rotation_Full\"",
            "Rotation Controlled Crystal Block",
            "Rotation Controlled Red/Green Block",
            "Rotation Controlled Colored Box",
            "Rotation Controlled Odd-Shaped Blocks",
            "Rotation Controlled Hanging Block",
            "Rotation Controlled 4-Way Thin Bar",
            "Rotation Controlled Bar",
            "Little Mouser Despawner",
            "Rotation Controlled Dish Platform",
            "Effect and Sound Player",
            "Horizontal Moving Platform",
            "Vertical Moving Stone Block",
            "Horizontal Moving Stone Block",
            "Unused Platform - \"Ac_Lift_Object_HMove_Big\"",
            "Unused Platform - \"En_Obj_Pol\"",
            "Tower Block",
            "Stone Block - Spiked on Left",
            "Stone Block - Spikes on Right",
            "Stone Block - Spiked on Left + Right",
            "Stone Block - Spiked on Top",
            "Stone Block - Spiked on Bottom",
            "Stone Block - Spiked on Top + Bottom",
            "Enormous Block with Spikes on Side",
            "Horizontal Lava Style Moving Platform",
            "Vertical Block Platform with Light Gem",
            "Blue and Orange Spiral Platform",
            "Movement Controller - Pairing? \"En_Pair_Obj_Parent\"",
            "Movement Controlled Platform - \"En_Pair_Obj_Child\"",
            "Movement Controlled Silver-Gear Block",
            "Movement Controlled Tower Block",
            "Ice Flow Generator",
            "Rail Controlled? - Floating Ice Flow Generator",
            "ICE_ASHIBA - Water Ice Flow",
            "ICE_ASHIBA_WATER - Ice Flow Water",
            "Rail Controlled Ice Flow",
            "Vertical Moving Platform",
            "Fake Star Coin",
            "Fall-When-On Platform",
            "Tilt Controlled Girder",
            "\"4x",
            "\"Beta Rising Tilt Platform\"",
            "Rising Tilt Controlled Girder Controller",
            "Rising Tilt Controlled Girder",
            "Line Controlled Tilt Controlled Girder",
            "Cloud Trampoline",
            "Grey Trampoline Wall",
            "EN_CHIKUWA_BLOCK - Donut Lift",
            "Falling Ledge Bar",
            "Bullet Bill Launcher",
            "Banzai Bill Launcher",
            "AC_WAKILIFT_STEP - Rising wood platform?",
            "Line Controlled Moving Platform",
            "Line Controlled Platform with Bolt",
            "Palm Tree",
            "Moving Flashlight Raft",
            "Line Controlled Rotating Pink Block",
            "Rope Ladder",
            "\"Vine Swing\"",
            "Swinging Vine / Chain",
            "Message Box",
            "Manacle Ring",
            "Rotation Controlled Hanging Chain Platform",
            "One Way Moving Platform",
            "\"Swinging Hinged Platform\"",
            "4-Platform Spinner",
            "Movement Controlled Platform - \"En_Rail_Polygon\"",
            "Movement Controlled Ice Block",
            "Movement Controller - Use Rails",
            "Light Steel Platform - \"En_Rail_Poly_Child\"",
            "Freefall Ghost House Platform",
            "Teetering Stalagmite Platform",
            "Hanging Chained Falling Platform",
            "Rotating Bullet Bill Launcher",
            "Red Coin Ring",
            "Floating Barrel",
            "Portable Spring",
            "Orange \"?\"",
            "Big Breakable Brick Block",
            "Rail Controlled Icy Block Train",
            "Giant Floating Log",
            "OBJ_KAMECK - Kamek",
            "Movement Controller - Vertical Mushroom Platform with Bolt",
            "Movement Controlled Vertical Mushroom Platform",
            "Roulette Block",
            "Scale Platform",
            "AC_LIFT_SCALES_STEP - Scale Platform Platform",
            "Meteor",
            "Unused Tilt Platform - \"Ac_Lift_Boss_Remocon_Seesaw\"",
            "Tile God Event",
            "Icicle",
            "Question Block",
            "Question Block - Unused",
            "Brick Block",
            "Hidden Question Block",
            "Unused Sprite - \"Ac_Obj_Clear_Block\"",
            "Line Controlled Question Block",
            "Line Controlled Brick Block",
            "Floating Question Block",
            "Player-Block",
            "EN_BLOCK_STAFFROLL - Staff Roll Letter Block",
            "Movement Controller - \"Elastic_Kinoko_Parent\"",
            "Extending / Contracting Line Block",
            "Checkered Spring Block",
            "Jumbo Ray Spawn Area",
            "MANTA_MGR2",
            "Jumbo Ray",
            "Extending / Contracting Mushroom Platform",
            "Unused Sprite - \"En_Rotation_Block\"",
            "Rotation Controlled Coin",
            "Rotation Controlled Pipe [Buggy]",
            "Rotation Controlled Question Block",
            "Rotation Controlled Brick Block",
            "Rotating Chain Link Wheel",
            "Tilt Controlled Castle Grate",
            "Boss - Balboa Wrench",
            "Giant Ice Block [4x4]",
            "\"Icy Blocks\"",
            "Wood / Metal Crate",
            "Parabeetle",
            "Heavy Parabeetle",
            "Airship Nut Platform [2x6]",
            "Giant Buzzy Beetle",
            "Wrench",
            "Cannon",
            "Cannon - Multi-use",
            "Cannon - 4-Way [3x3",
            "Cannon - Giant 4-Way with Pipe",
            "Rotating Flame Jet Cannon",
            "Lighting - Circle",
            "Lighting - Giant Glow Block",
            "Lighting - Rotation Controlled Spotlight",
            "Mega Falling Icicle",
            "Unused Sprite - \"Ac_Water_Bubble_Parent\"",
            "Unused Sprite - \"Ac_Water_Bubble_Cannon\"",
            "Rising / Lowering Bullet Bill Cannon",
            "Muncher",
            "Lighting - Lamp",
            "Lakitu Cloud Block",
            "Moving Chain-Link",
            "Bush",
            "Bouncing Lemmy Ball",
            "Question Block with Toad (Single Player)",
            "Brick Block with Toad (Single Player)",
            "AC_FREEZER - Ice block?",
            "Metal Bar",
            "EN_ITEM_IVY - Growing vine",
            "Topman",
            "Pipe Cannon",
            "Movement Controller - \"Kinoko_Lift_Parent\"",
            "Wiggling Mushroom Platform",
            "Bolt Controller - Bolt",
            "Bolt Controlled Metal Block",
            "Bolt Controlled Airship Platform",
            "Bolt Controlled Airship Platform Wire",
            "Warp Cannon",
            "Mushroom Platform",
            "Moving Pipe Facing Up",
            "Moving Pipe Facing Down",
            "Warp Pipe - Up",
            "Warp Pipe - Up (Works Without an Entrance)",
            "Warp Pipe - Down",
            "Warp Pipe - Right",
            "Warp Pipe - Left",
            "Move-When-On Metal Platform",
            "Move-When-On Ghost House Boxes",
            "Down-When-On Platform",
            "5-Enemy-Max",
            "Line Controlled Spine Coaster",
            "Line Controlled Player-Block Platform",
            "WATER_LIFT - Unused Water Platform",
            "Crowd Clapping Controller for Coin Collection",
            "Crowd Clapping Controller for Coin Collection #2",
            "Super Guide Block",
            "FAR_BG",
            "Water",
            "Lava",
            "Poison Water",
            "Quicksand",
            "Effect - Outdoors Fog",
            "Effect - Ghost Fog",
            "Water - \"Ac_Waterall_Rail\"",
            "Message Box",
            "Unused Sprite - \"Mask\"",
            "DTEST",
            "Movement Controller - Giant Floating Bubble",
            "Movement Controller - Giant Floating Bubble Unused",
            "Rising / Falling Water",
            "Rolling Hill",
            "Rolling Hill with 1",
            "Rotating Hill with 8",
            "Caslte Metal Gear",
            "Airship Wooden Gear",
            "Giant Turtle Shell Cave",
            "EN_BOSS_KOOPA_DEMO_CAGE     ",
            "Poltergeist Stand",
            "Effect - Glare",
            "Lighting - Underwater Lamp",
            "AC_COPYRIGHT",
            "WII_STRAP",
            "WM_CS_SEQ_MNG",
            "WORLD_CAMERA",
            "WM_MAP",
            "WM_IBARA",
            "WM_ANTLION_MNG",
            "WM_CASTLE",
            "WM_TOWER",
            "WM_PEACH_CASTLE",
            "Song Block",
            "Sing Along House",
            "WM_SINKSHIP",
            "WM_SWITCH",
            "WM_START",
            "WM_KINOKO_BASE",
            "WM_KINOKO_RED",
            "WM_KINOKO_1UP",
            "Pumpkin Goomba",
            "WM_COURSE",
            "WM_STOP",
            "WM_TORIDE",
            "WM_GHOST",
            "WM_DOKAN",
            "WM_CANNON",
            "WM_KOOPASHIP",
            "WM_BOSS_BASE",
            "WM_BOSS_LARRY",
            "WM_BOSS_ROY",
            "WM_BOSS_WENDY",
            "Bone Platform",
            "WM_BOSS_LEMMY",
            "WM_BOSS_MORTON",
            "WM_BOSS_LUDWIG",
            "WM_BOSS_KAMECK",
            "Captain Bowser: Koopa Flamethrower",
            "Challenge Star",
            "Boss - Samurshai",
            "WM_PAKKUN",
            "WM_BROS",
            "WM_JUGEM",
            "WM_PLAYER",
            "WM_SUBPLAYER",
            "WM_NOTE",
            "Shy Guy Giant",
            "WM_DIRECTOR",
            "Flipblock",
            "WM_ISLAND",
            "WM_ITEM",
            "WM_CS_W3_PALM",
            "WM_SURRENDER",
            "Make Your Own Model",
            "Captain Bowser: Koopa Throw",
            "WM_PAKKUNHEAD",
            "Bridge Bowser Bomb Drop",
            "WM_SMALLCLOUD",
            "WM_KOOPAJR",
            "WM_PEACH",
            "WM_BOARD",
            "Thundercloud",
            "Palace Activator",
            "WM_SANDPILLAR",
            "WM_YOGANPILLAR",
            "WM_KINOPIO",
            "WM_DANCE_PAKKUN",
            "WM_DOKANROUTE",
            "WM_HANACHAN",
            "WM_TOGEZO",
            "WM_MANTA",
            "WM_TERESA",
            "WORLD_SELECT",
            "WORLD_SELECT_GUIDE",
            "COLLECTION_COIN_BASE",
            "COLLECTION_COIN",
            "COURSE_SELECT_MENU",
            "NUMBER_OF_PEOPLE_CHANGE",
            "STOCK_ITEM",
            "STOCK_ITEM_SHADOW",
            "EASY_PAIRING",
            "WM_2D_PLAYER",
            "EVENT_OPENING_TITLE",
            "SELECT_PLAYER",
            "MULTI_COURSE_SELECT",
            "TIME_UP",
            "COURSE_TIME_UP",
            "YES_NO_WINDOW",
            "COURSE_SELECT_MANAGER",
            "FUKIDASHI_MANAGER",
            "SMALL_SCORE_MANAGER",
            "GAMEDISPLAY",
            "OTASUKE_INFO",
            "PAUSEWINDOW",
            "RESULT",
            "POINT_RESULT_MULTI",
            "POINT_RESULT_DATE_FILE",
            "POINT_RESULT_DATE_FILE_FREE",
            "GOAL_MANAGER",
            "COURSE_CLEAR",
            "OTEHON_CLEAR",
            "INFO_WINDOW",
            "SELECT_CURSOR",
            "WARNING_MANAGER",
            "SEQUENCE_BG",
            "GAME_OVER",
            "MODE_SELECT",
            "DATE_FILE",
            "FILE_SELECT",
            "CONTINUE",
            "MINI_GAME_CANNON",
            "MINI_GAME_WIRE",
            "MODEL_PLAY_MANAGER",
            "MODEL_PLAY_BASE",
            "MODEL_PLAY_DATE",
            "MODEL_PLAY_ARROW",
            "MODEL_PLAY_GUIDE",
            "MESSAGE_WINDOW",
            "CHARACTER_CHANGE_SELECT_BASE",
            "CHARACTER_CHANGE_SELECT_CONTENTS",
            "CHARACTER_CHANGE_SELECT_ARROW",
            "CHARACTER_CHANGE_INDICATOR",
            "MULTI_COURSE_SELECT_CONTENTS",
            "COLLECTION_COIN_DATE",
            "CONTROLLER_INFORMATION",
            "DRAW_GAME",
            "STAFF_CREDIT_SCORE",
            "THE_END",
            "DEMO_MESSAGE",
            "LETTER_WINDOW",
            "NO ASSIGNED FUNCTION",
            "LASTACTOR_STAGE",
            "LASTACTOR"});
            this.SpriteName.Location = new System.Drawing.Point(510, 43);
            this.SpriteName.Name = "SpriteName";
            this.SpriteName.Size = new System.Drawing.Size(286, 21);
            this.SpriteName.TabIndex = 16;
            this.SpriteName.SelectedIndexChanged += new System.EventHandler(this.SpriteName_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Actor Intenal Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(617, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sprite Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sprite Number:";
            // 
            // SpriteNum
            // 
            this.SpriteNum.Location = new System.Drawing.Point(202, 43);
            this.SpriteNum.Margin = new System.Windows.Forms.Padding(2);
            this.SpriteNum.Maximum = new decimal(new int[] {
            749,
            0,
            0,
            0});
            this.SpriteNum.Name = "SpriteNum";
            this.SpriteNum.Size = new System.Drawing.Size(90, 20);
            this.SpriteNum.TabIndex = 19;
            this.SpriteNum.ValueChanged += new System.EventHandler(this.SpriteNum_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(592, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "X Position:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(592, 141);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Y Position:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(553, 189);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Draw Distance X2:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(553, 165);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Draw Distance X1:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(553, 237);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Draw Distance Y2:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(553, 213);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Draw Distance Y1:";
            // 
            // saveAs
            // 
            this.saveAs.Enabled = false;
            this.saveAs.Location = new System.Drawing.Point(58, 337);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(75, 23);
            this.saveAs.TabIndex = 34;
            this.saveAs.Text = "Save As...";
            this.saveAs.UseVisualStyleBackColor = true;
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // copyClipboard
            // 
            this.copyClipboard.Enabled = false;
            this.copyClipboard.Location = new System.Drawing.Point(46, 308);
            this.copyClipboard.Name = "copyClipboard";
            this.copyClipboard.Size = new System.Drawing.Size(99, 23);
            this.copyClipboard.TabIndex = 35;
            this.copyClipboard.Text = "Copy to Clipboard";
            this.copyClipboard.UseVisualStyleBackColor = true;
            this.copyClipboard.Click += new System.EventHandler(this.copyClipboard_Click);
            // 
            // logs
            // 
            this.logs.AutoSize = true;
            this.logs.Location = new System.Drawing.Point(12, 716);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(100, 13);
            this.logs.TabIndex = 36;
            this.logs.Text = "Waiting for Action...";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 738);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.copyClipboard);
            this.Controls.Add(this.saveAs);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SSIDDY2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.SSIDDY1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.SSIDDX2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SSIDDX1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SSIYPos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SSIXPos);
            this.Controls.Add(this.isSSI);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SpriteNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SpriteName);
            this.Controls.Add(this.ActorIName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.spritefileinfotarget);
            this.Controls.Add(this.spritefileinfo);
            this.Controls.Add(this.example);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ingamespritename);
            this.Controls.Add(this.customspritename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cppfilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.ActorNum);
            this.Controls.Add(this.SSIGroupBox);
            this.Controls.Add(this.SFIGroupBox);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.saveGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "NewerSMBW Hook Generator";
            ((System.ComponentModel.ISupportInitialize)(this.ActorNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox saveGroupBox;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.GroupBox SFIGroupBox;
        private System.Windows.Forms.GroupBox SSIGroupBox;
        private System.Windows.Forms.NumericUpDown ActorNum;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cppfilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customspritename;
        private System.Windows.Forms.TextBox ingamespritename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button example;
        private System.Windows.Forms.CheckBox spritefileinfo;
        private System.Windows.Forms.TextBox spritefileinfotarget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ActorIName;
        private System.Windows.Forms.ComboBox SpriteName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown SpriteNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SSIXPos;
        private System.Windows.Forms.CheckBox isSSI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SSIYPos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SSIDDX2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SSIDDX1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SSIDDY2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox SSIDDY1;
        private System.Windows.Forms.Button saveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button copyClipboard;
        private System.Windows.Forms.Label logs;
    }
}

