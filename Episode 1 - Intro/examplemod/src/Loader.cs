using LogicAPI.Server;
using LogicLog;

public class Loader : ServerMod {
	protected override void Initialize(){
		Logger.Info("MyMod has been loaded");
	}
}