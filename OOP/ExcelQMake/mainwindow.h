#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include<map>
#include<vector>
#include<string>
namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();
    void printData() const;
    int getDataSize() const {
        return data.size();
    }
    double calculateExpression(const QString& cellText);
private slots:
    void on_pushButton_2_clicked();

    void on_lineEdit_cursorPositionChanged(int arg1, int arg2);

    void on_lineEdit_textChanged(const QString &arg1);


private:
    Ui::MainWindow *ui;
    std::vector<std::string> data;
};


double RPNtoNumber(std::string expression);

std::string expressionToRPN(const std::string& a);
#endif // MAINWINDOW_H
