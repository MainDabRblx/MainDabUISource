using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;

public class dWebHook : IDisposable
{
	private readonly WebClient dWebClient;

	private static NameValueCollection discordValues;

	public string ProfilePicture
	{
		get;
		set;
	}

	public string UserName
	{
		get;
		set;
	}

	public string WebHook
	{
		get;
		set;
	}

	static dWebHook()
	{
		dWebHook.discordValues = new NameValueCollection();
	}

	public dWebHook()
	{
		this.dWebClient = new WebClient();
	}

	public void Dispose()
	{
		this.dWebClient.Dispose();
	}

	public void SendMessage(string msgSend)
	{
		dWebHook.discordValues.Add("username", this.UserName);
		dWebHook.discordValues.Add("avatar_url", this.ProfilePicture);
		dWebHook.discordValues.Add("content", msgSend);
		this.dWebClient.UploadValues(this.WebHook, dWebHook.discordValues);
	}
}