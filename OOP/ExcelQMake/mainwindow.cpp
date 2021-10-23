#include "mainwindow.h"
#include "ui_mainwindow.h"
#include<iostream>
#include<QDebug>
#include <QTextStream>
#include<QMessageBox>
MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{

    ui->setupUi(this);

    int rowCount = 4;
    int columnCount = 4;

    ui->tableWidget->setRowCount(4);
    ui->tableWidget->setColumnCount(4);

    for(int i = 0; i < columnCount; ++i) ui->tableWidget->setColumnWidth(i, 115);
    for(int i = 0; i < rowCount; ++i)  ui->tableWidget->setRowHeight(i, 50);


}

MainWindow::~MainWindow()
{
    delete ui;
}


int MainWindow::calculateExpression(const QString& cellText) {
    return 5;
}


void MainWindow::on_pushButton_2_clicked()
{
    QTableWidgetItem * item= ui->tableWidget->currentItem();
    item->setText(QString::number(calculateExpression(item->text())));
}


void MainWindow::on_lineEdit_textChanged(const QString &arg1)
{
    data.push_back(arg1.toStdString());

}


void  MainWindow::printData() const {
    std::cout << getDataSize() << '\n';
    for(auto it: data) std::cout << it << '\n';
}
