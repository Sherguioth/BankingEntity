/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package view;

import java.util.ArrayList;
import java.util.List;
import webservices.Client;

/**
 *
 * @author Sherg
 */
public class Observer {
    
    private static Observer observer;
    
    private Client client;
    private List<IObserver> guiList;
    
    private Observer(){
        this.guiList = new ArrayList<>();
    }
    
    public static Observer getIstance(){
        if(observer == null){
            observer = new Observer();
            return observer ;
        }else{
            return observer;
        }
    }

    public Client getClient() {
        return client;
    }

    public void setClient(Client client) {
        this.client = client;
        this.updateAll();
    }
    
    public void addObserver(IObserver newObserver){
        this.guiList.add(newObserver);
    }
    
    public void updateAll(){
        for (IObserver gui: guiList){
            gui.update();
        }
    }
}
