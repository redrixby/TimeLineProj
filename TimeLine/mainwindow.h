#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include<workformmain.h>

namespace Ui {
class MainWindow;
}
class WorkFormMain;
class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private slots:
    void on_pushButton_clicked();

private:
    Ui::MainWindow *ui;
    WorkFormMain *workFormMain = new WorkFormMain();
};

#endif // MAINWINDOW_H
