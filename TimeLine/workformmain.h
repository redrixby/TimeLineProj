#ifndef WORKFORMMAIN_H
#define WORKFORMMAIN_H

#include <QWidget>

namespace Ui {
class WorkFormMain;
}

class WorkFormMain : public QWidget
{
    Q_OBJECT

public:
    explicit WorkFormMain(QWidget *parent = nullptr);
    ~WorkFormMain();

private slots:
    void on_pushButton_2_clicked();

    void on_pushButton_4_clicked();

    void on_pushButton_6_clicked();

    void on_pushButton_8_clicked();

private:
    Ui::WorkFormMain *ui;
    bool flagMenu=false;
    bool flagClickAbitur = false;
    bool flagClickUch = false;
    bool flagClickHrd = false;
};

#endif // WORKFORMMAIN_H
