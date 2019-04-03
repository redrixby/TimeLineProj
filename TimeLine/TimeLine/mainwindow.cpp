#include "mainwindow.h"
#include "ui_mainwindow.h"


MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    ui->widget_3->setVisible(0);
    ui->widget_welcome->setVisible(0);

}

MainWindow::~MainWindow()
{
    delete ui;
}




void MainWindow::on_loginButton_clicked()
{
 ui->loginWidget->hide();
 ui->widget_3->setVisible(1);
 ui->label_4->setVisible(0);
 ui->label_5->setVisible(0);
 ui->widget_welcome->setGeometry(150,316,841,364);
 ui->label_welcome->setText("Добрый день, "+ui->lineEditLogin->text());
 ui->label_welcome->setGeometry(20,5,800,160);
 ui->label_12->setGeometry(20,175,800,160);
 ui->widget_welcome->setVisible(1);
 ui->label_pers->setText(ui->lineEditLogin->text());
}


