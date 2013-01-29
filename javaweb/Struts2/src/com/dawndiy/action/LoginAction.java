package com.dawndiy.action;

import java.text.SimpleDateFormat;
import java.util.Date;

import com.opensymphony.xwork2.ActionContext;
import com.opensymphony.xwork2.ActionSupport;

public class LoginAction extends ActionSupport {

	private String username;

	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}

	
	public String execute(){

		SimpleDateFormat tempDate = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
		String time = tempDate.format(new Date());
		
		ActionContext.getContext().getSession().put("time", time);
//		ActionContext.getContext().getSession().put("user", getUsername());	//可直接在页面上获取
		
		return "in";
	}
	
	public String admin(){
		System.out.println("use admin()");
		username = "admin";
		return "in";
	}
	
	
}
