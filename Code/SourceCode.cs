namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = root.GetComponent<Space>(); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				} else { UnityEngine.Debug.Log("prop2 != null = false " ); }
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				} else { UnityEngine.Debug.Log("ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable0 != null = false " ); }
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			
			{
				Space subContext5 = root.GetComponent<Space>(); //IsContext = True IsNew = False
				
				if(subContext5 != null)
				{
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = loc.AddComponent<Entity>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext9 != null)
								{
									GODelegate Lambda10 = (UnityEngine.GameObject entity) => 
									{
										
										Place OperandVar12 = default(Place); //IsContext = False IsNew = False
										Place StoredVariable11 = AddContext9.GetComponent<Place>(); //IsContext = False IsNew = False
										if(StoredVariable11 != null)
										{
											OperandVar12 = StoredVariable11;
										} else { UnityEngine.Debug.Log("StoredVariable11 != null = false " ); }
										subContext5.Detach( (OperandVar12));
									};
									AddContext9.OnDestruction(Lambda10);
								} else { UnityEngine.Debug.Log("AddContext9 != null = false " ); }
							}
							Place AddContext13 = loc.AddComponent<Place>(); //IsContext = True IsNew = True
							Named AddContext14 = loc.AddComponent<Named>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext14 != null)
								{
									
									
									
									AddContext14.Set( ("main_name"), ("_1"), ("Some location"));
								} else { UnityEngine.Debug.Log("AddContext14 != null = false " ); }
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar16 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable15 = loc.GetComponent<Place>(); //IsContext = False IsNew = False
						if(StoredVariable15 != null)
						{
							OperandVar16 = StoredVariable15;
						} else { UnityEngine.Debug.Log("StoredVariable15 != null = false " ); }
						subContext5.Attach( (OperandVar16));
					}
				} else { UnityEngine.Debug.Log("subContext5 != null = false " ); }
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar30 = default(System.Boolean); //IsContext = False IsNew = False
			Card StoredVariable17 = root.GetComponent<Card>(); //IsContext = False IsNew = False
			if(StoredVariable17 != null)
			{
				System.Boolean ifResult18; //IsContext = False IsNew = False
				
				System.Boolean OperandVar25 = default(System.Boolean); //IsContext = False IsNew = False
				if(StoredVariable17 != null)
				{
					UnityEngine.GameObject prop19 = StoredVariable17.ShowedObject; //IsContext = False IsNew = False
					if(prop19 != null)
					{
						System.Boolean ifResult20; //IsContext = False IsNew = False
						System.Boolean OperandVar24 = default(System.Boolean); //IsContext = False IsNew = False
						Named OperandVar22 = default(Named); //IsContext = False IsNew = False
						Named StoredVariable21 = prop19.GetComponent<Named>(); //IsContext = False IsNew = False
						if(StoredVariable21 != null)
						{
							OperandVar22 = StoredVariable21;
						} else { UnityEngine.Debug.Log("StoredVariable21 != null = false " ); }
						System.Boolean prop23 = External.Has( (OperandVar22)); //IsContext = False IsNew = False
						OperandVar24 = prop23;
						if(ifResult20 =  (OperandVar24))
						{
							OperandVar25 = ifResult20;
						} else { UnityEngine.Debug.Log("ifResult20 =  (OperandVar24) = false " ); }
					} else { UnityEngine.Debug.Log("prop19 != null = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable17 != null = false " ); }
				
				System.Boolean OperandVar29 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.named_ui_marker OperandVar27 = default(Blackboards.named_ui_marker); //IsContext = False IsNew = False
				Blackboards.named_ui_marker StoredVariable26 = root.GetComponent<Blackboards.named_ui_marker>(); //IsContext = False IsNew = False
				if(StoredVariable26 != null)
				{
					OperandVar27 = StoredVariable26;
				} else { UnityEngine.Debug.Log("StoredVariable26 != null = false " ); }
				System.Boolean prop28 = External.Has( (OperandVar27)); //IsContext = False IsNew = False
				OperandVar29 = prop28;
				if(ifResult18 = ( ( (OperandVar25))) && ( (!(OperandVar29))))
				{
					applicable = true;
					OperandVar30 = applicable;
				} else { UnityEngine.Debug.Log("ifResult18 = ( ( (OperandVar25))) && ( (!(OperandVar29))) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable17 != null = false " ); }
			return (System.Boolean) (OperandVar30);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			UnityEngine.Debug.Log(root);
			
			
			
			root.AddComponent<Blackboards.named_ui_marker>();
			root.AddComponent<TextField>();
			
			{
				TextField subContext31 = root.GetComponent<TextField>(); //IsContext = True IsNew = False
				
				if(subContext31 != null)
				{
					System.String OperandVar36 = default(System.String); //IsContext = False IsNew = False
					Card StoredVariable32 = root.GetComponent<Card>(); //IsContext = False IsNew = False
					if(StoredVariable32 != null)
					{
						UnityEngine.GameObject prop33 = StoredVariable32.ShowedObject; //IsContext = False IsNew = False
						if(prop33 != null)
						{
							Named StoredVariable34 = prop33.GetComponent<Named>(); //IsContext = False IsNew = False
							if(StoredVariable34 != null)
							{
								
								System.String prop35 = StoredVariable34.Get( ("main_name")); //IsContext = False IsNew = False
								if(prop35 != null)
								{
									OperandVar36 = prop35;
								} else { UnityEngine.Debug.Log("prop35 != null = false " ); }
							} else { UnityEngine.Debug.Log("StoredVariable34 != null = false " ); }
						} else { UnityEngine.Debug.Log("prop33 != null = false " ); }
					} else { UnityEngine.Debug.Log("StoredVariable32 != null = false " ); }
					subContext31.Set( (OperandVar36));
				} else { UnityEngine.Debug.Log("subContext31 != null = false " ); }
			}
		}
        }
    }
}
