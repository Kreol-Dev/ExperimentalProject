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
					
					subContext5.Size = (System.Int32)( (5f));
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
										
										
										{
											
											if(entity != null)
											{
												
												{
													SpaceMarker subContext11 = AddContext9.GetComponent<SpaceMarker>(); //IsContext = True IsNew = False
													
													if(subContext11 != null)
													{
														
														{
															Space subContext12 = subContext11.CurrentSpace; //IsContext = True IsNew = False
															
															if(subContext12 != null)
															{
																Place OperandVar14 = default(Place); //IsContext = False IsNew = False
																Place StoredVariable13 = subContext12.GetComponent<Place>(); //IsContext = False IsNew = False
																if(StoredVariable13 != null)
																{
																	OperandVar14 = StoredVariable13;
																} else { UnityEngine.Debug.Log("StoredVariable13 != null = false " ); }
																subContext12.Detach( (OperandVar14));
															} else { UnityEngine.Debug.Log("subContext12 != null = false " ); }
														}
													} else { UnityEngine.Debug.Log("subContext11 != null = false " ); }
												}
											} else { UnityEngine.Debug.Log("entity != null = false " ); }
										}
									};
									AddContext9.OnDestruction(Lambda10);
								} else { UnityEngine.Debug.Log("AddContext9 != null = false " ); }
							}
							Place AddContext15 = loc.AddComponent<Place>(); //IsContext = True IsNew = True
							Named AddContext16 = loc.AddComponent<Named>(); //IsContext = True IsNew = True
							
							{
								
								if(AddContext16 != null)
								{
									
									
									
									AddContext16.Set( ("main_name"), ("_1"), ("Some location"));
								} else { UnityEngine.Debug.Log("AddContext16 != null = false " ); }
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar18 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable17 = loc.GetComponent<Place>(); //IsContext = False IsNew = False
						if(StoredVariable17 != null)
						{
							OperandVar18 = StoredVariable17;
						} else { UnityEngine.Debug.Log("StoredVariable17 != null = false " ); }
						subContext5.Attach( (OperandVar18));
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
			
			System.Boolean OperandVar32 = default(System.Boolean); //IsContext = False IsNew = False
			Card StoredVariable19 = root.GetComponent<Card>(); //IsContext = False IsNew = False
			if(StoredVariable19 != null)
			{
				System.Boolean ifResult20; //IsContext = False IsNew = False
				
				System.Boolean OperandVar27 = default(System.Boolean); //IsContext = False IsNew = False
				if(StoredVariable19 != null)
				{
					UnityEngine.GameObject prop21 = StoredVariable19.ShowedObject; //IsContext = False IsNew = False
					if(prop21 != null)
					{
						System.Boolean ifResult22; //IsContext = False IsNew = False
						System.Boolean OperandVar26 = default(System.Boolean); //IsContext = False IsNew = False
						Named OperandVar24 = default(Named); //IsContext = False IsNew = False
						Named StoredVariable23 = prop21.GetComponent<Named>(); //IsContext = False IsNew = False
						if(StoredVariable23 != null)
						{
							OperandVar24 = StoredVariable23;
						} else { UnityEngine.Debug.Log("StoredVariable23 != null = false " ); }
						System.Boolean prop25 = External.Has( (OperandVar24)); //IsContext = False IsNew = False
						OperandVar26 = prop25;
						if(ifResult22 =  (OperandVar26))
						{
							OperandVar27 = ifResult22;
						} else { UnityEngine.Debug.Log("ifResult22 =  (OperandVar26) = false " ); }
					} else { UnityEngine.Debug.Log("prop21 != null = false " ); }
				} else { UnityEngine.Debug.Log("StoredVariable19 != null = false " ); }
				
				System.Boolean OperandVar31 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.named_ui_marker OperandVar29 = default(Blackboards.named_ui_marker); //IsContext = False IsNew = False
				Blackboards.named_ui_marker StoredVariable28 = root.GetComponent<Blackboards.named_ui_marker>(); //IsContext = False IsNew = False
				if(StoredVariable28 != null)
				{
					OperandVar29 = StoredVariable28;
				} else { UnityEngine.Debug.Log("StoredVariable28 != null = false " ); }
				System.Boolean prop30 = External.Has( (OperandVar29)); //IsContext = False IsNew = False
				OperandVar31 = prop30;
				if(ifResult20 = ( ( (OperandVar27))) && ( (!(OperandVar31))))
				{
					applicable = true;
					OperandVar32 = applicable;
				} else { UnityEngine.Debug.Log("ifResult20 = ( ( (OperandVar27))) && ( (!(OperandVar31))) = false " ); }
			} else { UnityEngine.Debug.Log("StoredVariable19 != null = false " ); }
			return (System.Boolean) (OperandVar32);
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
				TextField subContext33 = root.GetComponent<TextField>(); //IsContext = True IsNew = False
				
				if(subContext33 != null)
				{
					System.String OperandVar38 = default(System.String); //IsContext = False IsNew = False
					Card StoredVariable34 = root.GetComponent<Card>(); //IsContext = False IsNew = False
					if(StoredVariable34 != null)
					{
						UnityEngine.GameObject prop35 = StoredVariable34.ShowedObject; //IsContext = False IsNew = False
						if(prop35 != null)
						{
							Named StoredVariable36 = prop35.GetComponent<Named>(); //IsContext = False IsNew = False
							if(StoredVariable36 != null)
							{
								
								System.String prop37 = StoredVariable36.Get( ("main_name")); //IsContext = False IsNew = False
								if(prop37 != null)
								{
									OperandVar38 = prop37;
								} else { UnityEngine.Debug.Log("prop37 != null = false " ); }
							} else { UnityEngine.Debug.Log("StoredVariable36 != null = false " ); }
						} else { UnityEngine.Debug.Log("prop35 != null = false " ); }
					} else { UnityEngine.Debug.Log("StoredVariable34 != null = false " ); }
					subContext33.Set( (OperandVar38));
				} else { UnityEngine.Debug.Log("subContext33 != null = false " ); }
			}
		}
        }
    }
}
