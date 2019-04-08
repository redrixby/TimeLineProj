#include "workformmain.h"
#include "ui_workformmain.h"

WorkFormMain::WorkFormMain(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::WorkFormMain)
{
    ui->setupUi(this);
}

WorkFormMain::~WorkFormMain()
{
    delete ui;
}

void WorkFormMain::on_pushButton_2_clicked()
{
    if (!flagMenu)
    {
      ui->widget->setGeometry(0,0,60,900);
      ui->pushButton_2->setGeometry(10,5,40,20);
      ui->pushButton_2->setStyleSheet("background-image: url(:/new/prefix1/open_menu_close.png);border: 0;");
      ui->widget_2->setGeometry(60,0,1180,30);
      ui->lineEdit->setGeometry(34,5,1131,20);
      ui->lineEdit_2->setVisible(false);
      ui->pushButton_3->setGeometry(17,8,24,24);
      ui->pushButton_4->setGeometry(15,163,30,30);
      ui->pushButton_4->setStyleSheet("background-image: url(:/new/prefix1/abitur.png);border: 0;");
      ui->pushButton_6->setGeometry(15,220,30,30);
      ui->pushButton_6->setStyleSheet("background-image: url(:/new/prefix1/uch.png);border: 0;");
      ui->pushButton_8->setGeometry(15,275,30,30);
      ui->pushButton_8->setStyleSheet("background-image: url(:/new/prefix1/hrd.png);border: 0;");
      ui->pushButton_11->setGeometry(15,689,30,30);
      ui->pushButton_11->setStyleSheet("background-image: url(:/new/prefix1/sittengs.png);border: 0;");
      ui->pushButton_12->setGeometry(15,749,30,30);
      ui->pushButton_12->setStyleSheet("background-image: url(:/new/prefix1/quastion.png);border: 0;");
      ui->pushButton_13->setGeometry(15,809,30,30);
      ui->pushButton_13->setStyleSheet("background-image: url(:/new/prefix1/chat.png);border: 0;");
      ui->label_3->setVisible(false);
      flagMenu=true;
    } else
    {
      ui->widget->setGeometry(0,0,197,900);
      ui->pushButton_2->setGeometry(10,5,62,20);
      ui->pushButton_2->setStyleSheet("background-image: url(:/new/prefix1/open_menu.png); border: 0;");
      ui->widget_2->setGeometry(197,0,1043,30);
      ui->lineEdit->setGeometry(34,5,994,20);
      ui->lineEdit_2->setVisible(true);
      ui->pushButton_3->setGeometry(172,8,24,24);
      ui->pushButton_4->setGeometry(15,160,155,40);
      ui->pushButton_4->setStyleSheet("background-image: url(:/new/prefix1/new_abit.png);border: 0;");
      ui->pushButton_6->setGeometry(15,215,167,40);
      ui->pushButton_6->setStyleSheet("background-image: url(:/new/prefix1/new_uch.png);border: 0;");
      ui->pushButton_8->setGeometry(15,270,155,40);
      ui->pushButton_8->setStyleSheet("background-image: url(:/new/prefix1/new_hrd.png);border: 0;");
      ui->pushButton_11->setGeometry(15,687,143,40);
      ui->pushButton_11->setStyleSheet("background-image: url(:/new/prefix1/new_sittengs.png);border: 0;");
      ui->pushButton_12->setGeometry(15,747,143,40);
      ui->pushButton_12->setStyleSheet("background-image: url(:/new/prefix1/new_quastion.png);border: 0;");
      ui->pushButton_13->setGeometry(15,807,143,40);
      ui->pushButton_13->setStyleSheet("background-image: url(:/new/prefix1/new_chat.png);border: 0;");
      ui->label_3->setVisible(true);
      flagMenu=false;
    }


}

void WorkFormMain::on_pushButton_4_clicked()
{
    if(!flagClickAbitur)
    {
        ui->pushButton_4->setGeometry(5,157,187,45);
        ui->pushButton_4->setStyleSheet("background-image: url(:/new/prefix1/click_abit.png);border: 0;");
        flagClickAbitur=true;
    }else
    {
        ui->pushButton_4->setGeometry(15,160,155,40);
        ui->pushButton_4->setStyleSheet("background-image: url(:/new/prefix1/new_abit.png);border: 0;");
        flagClickAbitur=false;
    }

}

void WorkFormMain::on_pushButton_6_clicked()
{
    if(!flagClickUch)
    {
        ui->pushButton_6->setStyleSheet("background-image: url(:/new/prefix1/click_uch.png);border: 0;");
        ui->pushButton_6->setGeometry(5,212,187,45);
        flagClickUch=true;
    }else
    {
        ui->pushButton_6->setStyleSheet("background-image: url(:/new/prefix1/new_uch.png);border: 0;");
        ui->pushButton_6->setGeometry(15,215,167,40);
        flagClickUch=false;
    }
}

void WorkFormMain::on_pushButton_8_clicked()
{
    if(!flagClickHrd)
    {
        ui->pushButton_8->setGeometry(5,268,187,45);
        ui->pushButton_8->setStyleSheet("background-image: url(:/new/prefix1/click_hrd.png);border: 0;");
        flagClickHrd=true;
    }else
    {
        ui->pushButton_8->setGeometry(15,270,155,40);
        ui->pushButton_8->setStyleSheet("background-image: url(:/new/prefix1/new_hrd.png);border: 0;");
        flagClickHrd=false;
    }
}
