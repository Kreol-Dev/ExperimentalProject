public class generate_name_action 
{
	public bool Scope(object obj)
	{
		return Core.HasName(obj);
	}

	var names_scope = new Scope();
	var fallback_names = new Scope();
	var second_name = new Scope();

	var second_name_husband_name = new Var<string>();
	var second_name_family_name = new Var<string>();
	var second_name_random_name = new Var<string>();
	public void Action(object obj)
	{

		//foreach value = value.clean()
		{
			names_scope.Union(Core.FactionNames(obj));
			names_scope.Union(Core.TraitsNames(obj));
			names_scope.Intersect(Core.CultureNames(obj));
		}

		{
			fallback_names.Union(Core.FactionNames(obj));
			fallback_names.Union(Core.TraitsNames(obj));
			fallback_names.Weight(Core.SimilarTraits(Core.TraitsNames(obj)));
		}

		{
			
			

			second_name.Union(husband_name);
			second_name.Union(family_name);
			second_name.Union(random_name);
		

			

			if(Core.HasFamily(obj) && !husband_name) // ! husband_name.HasValue()
			{
				
				Core.HusbandName(second_name_family_name, obj);
			}

			if (Core.SexIs(Sexes.Female) && Core.FamilyStatus(Family.Married))
			{
				Core.HusbandName(second_name_husband_name, obj);
			}

			if (!husband_name && !family_name)
			{
				Core.NewName(second_name_random_name, Core.CultureSecondNames(obj));
			}
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