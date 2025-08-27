using System;

namespace Sonic
{
	[Serializable]
	public class Invulnerable : ImpactEffectBehaviour
	{
		public override void OnAdd(ImpactEffect oEffect)
		{
			oEffect.actor.ImpactIncoming += oEffect.HandleTrigger;
		}

		public override void OnRemove(ImpactEffect oEffect)
		{
			oEffect.actor.ImpactIncoming -= oEffect.HandleTrigger;
		}

		public override void OnTrigger(ImpactEffect oEffect, ActorEventArgs e)
		{
			if (e.context is ContextImpactIncoming)
			{
				ActorImpactEventArgs e2 = e as ActorImpactEventArgs;
				ImpactApplicationData impactData = e2.impactData;
				if (impactData != null)
				{
					impactData.prevented = true;
				}
			}
		}
	}
}
