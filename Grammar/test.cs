public class generate_name_action 
{
	public bool Scope(object obj)
	{
		return Core.HasName(obj);
	}

	public void Action(object obj)
	{
		var names_scope = new Scope();
		scope.Union(Core.FactionNames(obj));
		scope.Union(Core.TraitsNames(obj));
		scope.Intersect(Core.CultureNames(obj));

		var fallback_names = new Scope();
		scope.Union(Core.FactionNames(obj));
		scope.Union(Core.TraitsNames(obj));
		fallback_names.Weight(Core.SimilarTraits(Core.TraitsNames(obj)));

		var second_name = new Scope();
		{
			var husband_name = new Var<string>();
			if (Core.SexIs(Sexes.Female) && Core.FamilyStatus(Family.Married))
			{
				husband_name.Value = Core.HusbandName(obj);
			}
			var family_name = new Var<string>();
			if(Core.HasFamily(obj) && !husband_name) // ! husband_name.HasValue()
			{
				family_name.Value = Core.FamilyName();
			}
			var random_name = new Var<string>(Core.NewName, Core.CultureSecondNames);
			if (!husband_name && !family_name)
			{
				random_name.Call();
			}

			second_name.Union(husband_name);
			second_name.Union(family_name);
			second_name.Union(random_name);
		}

		Core.SetName(
			Core.Concat(
				Core.RandomFrom(
					names_scope, 
					Core.MostWeigth(
						fallback_names, 
						Core.NewName(
							Core.CultureNames(obj), 
							"Error name")
						)
					),
				" ",
				Core.SingleFrom(
					second_name,
					"Error name"
					)
				)
			);
	}
}