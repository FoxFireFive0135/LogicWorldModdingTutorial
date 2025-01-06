using LogicAPI.Server.Components;

namespace mymod{
	public class NANDGATE : LogicComponent{
		protected override void DoLogicUpdate(){
			Outputs[0].On = !(Inputs[0].On && Inputs[1].On);
		}
	}
}